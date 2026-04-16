using Final_Project.Context;
using Final_Project.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly MyContext db;

        public SubjectController(MyContext context)
        {
            db = context;
        }

        // ================= GET ALL SUBJECTS =================
        [Authorize]
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var subjects = await db.Subjects
                .Include(s => s.Professor)
                .Select(s => new
                {
                    s.Sub_ID,
                    s.Sub_Name,
                    s.Sub_Code,
                    ProfessorName = s.Professor != null ? s.Professor.Pro_Name : null
                })
                .ToListAsync();

            return Ok(subjects);
        }

        // ================= GET SUBJECT BY ID =================
        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var subject = await db.Subjects
                .Include(s => s.Professor)
                .Where(s => s.Sub_ID == id)
                .Select(s => new
                {
                    s.Sub_ID,
                    s.Sub_Name,
                    s.Sub_Code,
                    ProfessorName = s.Professor != null ? s.Professor.Pro_Name : null
                })
                .FirstOrDefaultAsync();

            if (subject == null)
                return NotFound("Subject not found");

            return Ok(subject);
        }

        // ================= ADD SUBJECT =================
        [Authorize(Roles = "Professor")]
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] Subject model)
        {
            if (model == null)
                return BadRequest("Invalid data");

            db.Subjects.Add(model);
            await db.SaveChangesAsync();

            return Ok(model);
        }

        // ================= UPDATE SUBJECT =================
        [Authorize(Roles = "Professor")]
        [HttpPut("update/{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Subject model)
        {
            var subject = await db.Subjects.FindAsync(id);

            if (subject == null)
                return NotFound("Subject not found");

            subject.Sub_Name = model.Sub_Name;
            subject.Sub_Code = model.Sub_Code;
            subject.Professor_Id = model.Professor_Id;

            await db.SaveChangesAsync();

            return Ok(subject);
        }

        // ================= DELETE SUBJECT =================
        [Authorize(Roles = "Professor")]
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var subject = await db.Subjects.FindAsync(id);

            if (subject == null)
                return NotFound("Subject not found");

            db.Subjects.Remove(subject);
            await db.SaveChangesAsync();

            return Ok("Subject deleted successfully");
        }

        // ================= PROFESSOR SUBJECTS =================
        [Authorize(Roles = "Professor")]
        [HttpGet("my-subjects")]
        public async Task<IActionResult> MySubjects()
        {
            var professorId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!int.TryParse(professorId, out int id))
                return Unauthorized();

            var subjects = await db.Subjects
                .Where(s => s.Professor_Id == id)
                .Select(s => new
                {
                    s.Sub_ID,
                    s.Sub_Name,
                    s.Sub_Code
                })
                .ToListAsync();

            return Ok(subjects);
        }

        // ================= STUDENT SUBJECTS =================
        [Authorize(Roles = "Student")]
        [HttpGet("student-subjects")]
        public async Task<IActionResult> StudentSubjects()
        {
            var studentId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!int.TryParse(studentId, out int id))
                return Unauthorized();

            var subjects = await db.StudentSubjects
                .Include(ss => ss.Subject)
                .Where(ss => ss.Student_Id == id)
                .Select(ss => new
                {
                    ss.Subject.Sub_ID,
                    ss.Subject.Sub_Name,
                    ss.Subject.Sub_Code
                })
                .ToListAsync();

            return Ok(subjects);
        }

        // ================= ASSIGN PROFESSOR (DTO) =================
        [Authorize(Roles = "Professor")]
        [HttpPost("assign-professor")]
        public async Task<IActionResult> AssignProfessor([FromBody] AssignProfessorDTO dto)
        {
            var subject = await db.Subjects.FindAsync(dto.SubjectId);

            if (subject == null)
                return NotFound("Subject not found");

            var professor = await db.Professors.FindAsync(dto.ProfessorId);

            if (professor == null)
                return NotFound("Professor not found");

            subject.Professor_Id = dto.ProfessorId;

            await db.SaveChangesAsync();

            return Ok("Professor assigned successfully");
        }

        // ================= GET STUDENTS BY SUBJECT =================
        [Authorize(Roles = "Professor")]
        [HttpGet("{subjectId}/students")]
        public async Task<IActionResult> GetStudentsBySubject(int subjectId)
        {
            var students = await db.StudentSubjects
                .Include(ss => ss.Student)
                .Where(ss => ss.Subject_Id == subjectId)
                .Select(ss => new
                {
                    StudentId = ss.Student_Id,
                    StudentName = ss.Student != null ? ss.Student.St_Name : "Unknown"
                })
                .ToListAsync();

            if (!students.Any())
                return NotFound("No students registered in this subject.");

            return Ok(students);
        }
    }

    // ================= DTO =================
    public class AssignProfessorDTO
    {
        public int SubjectId { get; set; }
        public int ProfessorId { get; set; }
    }
}