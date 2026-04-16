using Final_Project.Context;
using Final_Project.Model;
using Final_Project.secure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly MyContext db;

        public StudentController(MyContext context)
        {
            db = context;
        }

        // ================= SAFE USER ID =================
        private bool TryGetUserId(out int userId)
        {
            userId = 0;

            var claim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return int.TryParse(claim, out userId);
        }

        // ================= LIST ALL STUDENTS =================
        [Authorize(Roles = "Student")]
        [HttpGet("list-all-student")]
        public async Task<IActionResult> GetAllStudent()
        {
            var std = await db.Students.ToListAsync();
            return Ok(std);
        }

        // ================= GET STUDENT BY ID =================
        [Authorize(Roles = "Student")]
        [HttpGet("list-by-{id}")]
        public async Task<IActionResult> GetStudentById(int id)
        {
            var std = await db.Students
                .FirstOrDefaultAsync(x => x.Student_id == id);

            if (std == null)
                return NotFound($"Student ID {id} not found");

            return Ok(std);
        }

        // ================= ATTENDANCE PERCENTAGE =================
        [Authorize(Roles = "Student")]
        [HttpGet("attendance-percentage")]
        public async Task<IActionResult> GetAttendance()
        {
            if (!TryGetUserId(out int studentId))
                return Unauthorized(new { message = "Invalid token" });

            var student = await db.Students
                .Include(s => s.Attendances)
                .ThenInclude(a => a.Subject)
                .FirstOrDefaultAsync(s => s.Student_id == studentId);

            if (student == null)
                return NotFound(new { message = "Student not found" });

            var result = student.Attendances
                .Where(a => a.Subject != null)
                .GroupBy(a => a.Subject.Sub_Name)
                .Select(g =>
                {
                    int total = g.Count();
                    int present = g.Count(x => x.Present);

                    double percentage = total == 0 ? 0 :
                        (double)present / total * 100;

                    int required = (int)Math.Ceiling((75 * total) / 100.0);
                    int needed = required - present;

                    return new
                    {
                        Subject = g.Key,
                        TotalLectures = total,
                        PresentLectures = present,
                        Percentage = Math.Round(percentage, 2),
                        Alert = percentage < 75,
                        NeededLectures = needed > 0 ? needed : 0
                    };
                });

            return Ok(result);
        }

        // ================= GET QR TEXT =================
        [Authorize(Roles = "Student")]
        [HttpGet("my-qr")]
        public async Task<IActionResult> GetMyQr()
        {
            if (!TryGetUserId(out int studentId))
                return Unauthorized("Invalid token");

            var student = await db.Students
                .FirstOrDefaultAsync(s => s.Student_id == studentId);

            if (student == null)
                return NotFound("Student not found");

            var hash = QrHelper.GenerateHash(studentId);

            return Ok(new
            {
                qrText = $"{studentId}|{hash}"
            });
        }

        // ================= QR IMAGE =================
        [Authorize(Roles = "Student")]
        [HttpGet("my-qr-image")]
        public async Task<IActionResult> GetQrImage()
        {
            if (!TryGetUserId(out int studentId))
                return Unauthorized("Invalid token");

            var student = await db.Students
                .FirstOrDefaultAsync(s => s.Student_id == studentId);

            if (student == null)
                return NotFound();

            var hash = QrHelper.GenerateHash(studentId);
            var qrText = $"{studentId}|{hash}";

            var qrGenerator = new QRCoder.QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(
                qrText,
                QRCoder.QRCodeGenerator.ECCLevel.Q
            );

            var qrCode = new QRCoder.PngByteQRCode(qrCodeData);
            byte[] image = qrCode.GetGraphic(20);

            return File(image, "image/png");
        }
    }
}