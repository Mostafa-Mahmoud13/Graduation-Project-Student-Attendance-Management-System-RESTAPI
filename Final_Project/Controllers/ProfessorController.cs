using Final_Project.Context;
using Final_Project.DTO;
using Final_Project.Model;
using Final_Project.secure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.Security.Claims;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly MyContext db;

        public ProfessorController(MyContext context)
        {
            db = context;
        }

        // ================= SAFE USER ID =================
        private bool TryGetProfessorId(out int professorId)
        {
            professorId = 0;
            var claim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return int.TryParse(claim, out professorId);
        }

        // ================= MY STUDENTS =================
        [Authorize(Roles = "Professor")]
        [HttpGet("my-students")]
        public async Task<IActionResult> GetMyStudents()
        {
            if (!TryGetProfessorId(out int professorId))
                return Unauthorized("Invalid token");

            var students = await db.StudentSubjects
                .Where(ss => ss.Subject != null && ss.Subject.Professor_Id == professorId)
                .Select(ss => new
                {
                    ss.Student.Student_id,
                    ss.Student.St_Name,
                    ss.Student.St_code,
                    ss.Student.Department
                })
                .Distinct()
                .ToListAsync();

            return Ok(students);
        }

        // ================= LIST ALL STUDENTS =================
        [Authorize(Roles = "Professor")]
        [HttpGet("list-all-students")]
        public async Task<IActionResult> ListAllStudents()
        {
            var students = await db.Students.ToListAsync();
            return Ok(students);
        }

        // ================= LIST PROFESSORS =================
        [Authorize(Roles = "Professor")]
        [HttpGet("list-professors")]
        public async Task<IActionResult> GetAllProfessors()
        {
            var prof = await db.Professors.ToListAsync();
            return Ok(prof);
        }

        // ================= GET PROFESSOR BY ID =================
        [Authorize(Roles = "Professor")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProf(int id)
        {
            var prof = await db.Professors
                .FirstOrDefaultAsync(x => x.Professor_id == id);

            if (prof == null)
                return NotFound("Professor not found");

            return Ok(prof);
        }

        // ================= ADD STUDENT =================
        [Authorize(Roles = "Professor")]
        [HttpPost("add-student")]
        public async Task<IActionResult> AddStudent([FromBody] Student s)
        {
            if (s == null)
                return BadRequest("Invalid data");

            db.Students.Add(s);
            await db.SaveChangesAsync();

            return Ok(s);
        }

        // ================= UPDATE STUDENT =================
        [Authorize(Roles = "Professor")]
        [HttpPut("update-student/{id}")]
        public async Task<IActionResult> UpdateStudent(int id, [FromBody] Student s)
        {
            var student = await db.Students.FindAsync(id);

            if (student == null)
                return NotFound("Student not found");

            student.St_Name = s.St_Name;
            student.Email = s.Email;
            student.St_code = s.St_code;
            student.Department = s.Department;

            await db.SaveChangesAsync();

            return Ok(student);
        }

        // ================= DELETE STUDENT =================
        [Authorize(Roles = "Professor")]
        [HttpDelete("delete-student/{id}")]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            var student = await db.Students.FindAsync(id);

            if (student == null)
                return NotFound("Student not found");

            db.Students.Remove(student);
            await db.SaveChangesAsync();

            return Ok("Student deleted");
        }

        // ================= MARK ATTENDANCE =================
        [Authorize(Roles = "Professor")]
        [HttpPost("mark-attendance")]
        public async Task<IActionResult> MarkAttendance([FromBody] AttendanceDTO model)
        {
            if (model == null || model.Students == null || !model.Students.Any())
                return BadRequest("Invalid data");

            if (!TryGetProfessorId(out int professorId))
                return Unauthorized();

            foreach (var item in model.Students)
            {
                var exists = await db.Attendances.AnyAsync(a =>
                    a.Student_Id == item.StudentId &&
                    a.Subject_Id == model.SubjectId &&
                    a.Date.Date == model.Date.Date);

                if (!exists)
                {
                    db.Attendances.Add(new Attendance
                    {
                        Student_Id = item.StudentId,
                        Subject_Id = model.SubjectId,
                        Professor_Id = professorId,
                        Present = item.Present,
                        Date = model.Date
                    });
                }
            }

            await db.SaveChangesAsync();

            return Ok("Attendance saved successfully");
        }

        // ================= SCAN QR =================
        [Authorize(Roles = "Professor")]
        [HttpPost("scan-qr-attendance")]
        public async Task<IActionResult> ScanQrAttendance([FromBody] ScanQrDTO model)
        {
            if (model == null || string.IsNullOrWhiteSpace(model.QrText))
                return BadRequest(new { message = "QR is empty" });

            var parts = model.QrText.Split('|');

            if (parts.Length < 2 || !int.TryParse(parts[0], out int studentId))
                return BadRequest(new { message = "Invalid QR Code" });

            if (!QrHelper.Validate(studentId, parts[1]))
                return BadRequest(new { message = "Fake QR Code ❌" });

            var student = await db.Students
                .FirstOrDefaultAsync(s => s.Student_id == studentId);

            if (student == null)
                return NotFound(new { message = "Student not found" });

            if (!TryGetProfessorId(out int professorId))
                return Unauthorized(new { message = "Invalid token" });

            // ✅ تحقق إن الطالب مسجل في المادة
            var isEnrolled = await db.StudentSubjects.AnyAsync(ss =>
                ss.Student_Id == studentId && ss.Subject_Id == model.SubjectId);

            if (!isEnrolled)
                return BadRequest(new { message = "Student not enrolled in this subject" });

            var now = DateTime.UtcNow;
            var today = now.Date;

            var existing = await db.Attendances
                .FirstOrDefaultAsync(a =>
                    a.Student_Id == studentId &&
                    a.Subject_Id == model.SubjectId &&
                    a.Date.Date == today);

            // ✅ لو موجود قبل كده
            if (existing != null)
            {
                return Ok(new
                {
                    message = "Already scanned",
                    status = "duplicate",
                    student = student.St_Name,
                    time = existing.Date
                });
            }

            // ✅ تسجيل الحضور
            db.Attendances.Add(new Attendance
            {
                Student_Id = studentId,
                Subject_Id = model.SubjectId,
                Professor_Id = professorId,
                Present = true,
                Date = now
            });

            await db.SaveChangesAsync();

            return Ok(new
            {
                message = "Attendance recorded ✔",
                status = "success",
                student = student.St_Name,
                time = now
            });
        }

        // ================= UPLOAD EXCEL =================
        [Authorize(Roles = "Professor")]
        [HttpPost("upload-students")]
        public async Task<IActionResult> UploadStudents(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded");

            using var stream = new MemoryStream();
            await file.CopyToAsync(stream);

            using var package = new ExcelPackage(stream);
            var worksheet = package.Workbook.Worksheets[0];

            if (worksheet.Dimension == null)
                return BadRequest("Empty file");

            int rowCount = worksheet.Dimension.Rows;

            for (int row = 2; row <= rowCount; row++)
            {
                db.Students.Add(new Student
                {
                    St_Name = worksheet.Cells[row, 1].Text,
                    Email = worksheet.Cells[row, 2].Text,
                    St_code = int.TryParse(worksheet.Cells[row, 3].Text, out var code) ? code : 0,
                    Department = worksheet.Cells[row, 4].Text,
                    Password = "123456"
                });
            }

            await db.SaveChangesAsync();

            return Ok("Students uploaded successfully");
        }

        // ================= DOWNLOAD ATTENDANCE =================
        [Authorize(Roles = "Professor")]
        [HttpGet("download-my-attendance")]
        public async Task<IActionResult> DownloadMyAttendance()
        {
            if (!TryGetProfessorId(out int professorId))
                return Unauthorized();

            var professor = await db.Professors.FindAsync(professorId);
            if (professor == null)
                return NotFound();

            var subjects = await db.Subjects
                .Where(s => s.Professor_Id == professorId)
                .ToListAsync();

            if (!subjects.Any())
                return BadRequest("No subjects found");

            var subjectIds = subjects.Select(s => s.Sub_ID).ToList();

            var attendances = await db.Attendances
                .Include(a => a.Student)
                .Where(a => subjectIds.Contains(a.Subject_Id))
                .ToListAsync();

            ExcelPackage.License.SetNonCommercialPersonal("Final_Project");

            using var package = new ExcelPackage();
            var sheet = package.Workbook.Worksheets.Add("Attendance");

            int row = 1;

            foreach (var subject in subjects)
            {
                // ===== SUBJECT TITLE =====
                sheet.Cells[row, 1, row, 4].Merge = true;
                sheet.Cells[row, 1].Value = subject.Sub_Name;

                using (var range = sheet.Cells[row, 1, row, 4])
                {
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.DarkBlue);
                    range.Style.Font.Color.SetColor(System.Drawing.Color.White);
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                }

                row++;

                // ===== HEADER =====
                sheet.Cells[row, 1].Value = "Student";
                sheet.Cells[row, 2].Value = "Present";
                sheet.Cells[row, 3].Value = "Absent";
                sheet.Cells[row, 4].Value = "Percentage";

                using (var range = sheet.Cells[row, 1, row, 4])
                {
                    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                    range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);
                    range.Style.Font.Bold = true;
                    range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    range.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    range.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    range.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    range.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                }

                row++;

                var data = attendances
                    .Where(a => a.Subject_Id == subject.Sub_ID)
                    .GroupBy(a => a.Student)
                    .Select(g => new
                    {
                        Name = g.Key.St_Name,
                        Present = g.Count(x => x.Present),
                        Absent = g.Count(x => !x.Present),
                        Percent = g.Count(x => x.Present) * 1.0 / g.Count()
                    });

                bool alternate = false;

                foreach (var item in data)
                {
                    sheet.Cells[row, 1].Value = item.Name;
                    sheet.Cells[row, 2].Value = item.Present;
                    sheet.Cells[row, 3].Value = item.Absent;
                    sheet.Cells[row, 4].Value = item.Percent;

                    sheet.Cells[row, 4].Style.Numberformat.Format = "0.00%";

                    if (alternate)
                    {
                        using (var range = sheet.Cells[row, 1, row, 4])
                        {
                            range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.FromArgb(240, 240, 240));
                        }
                    }

                    using (var range = sheet.Cells[row, 1, row, 4])
                    {
                        range.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        range.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        range.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        range.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                        range.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    }

                    alternate = !alternate;
                    row++;
                }

                row += 2;
            }

            sheet.Cells.AutoFitColumns();

            // ===== FILE NAME (WITH PROFESSOR NAME) =====
            var safeName = string.Concat(professor.Pro_Name
                .Where(c => !Path.GetInvalidFileNameChars().Contains(c)))
                .Replace(" ", "_");

            var fileName = $"Dr_{safeName}_{DateTime.Now:yyyyMMdd}.xlsx";

            return File(
                package.GetAsByteArray(),
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                fileName
            );
        }
    }
}