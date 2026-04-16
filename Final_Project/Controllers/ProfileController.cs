using Final_Project.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly MyContext db;

        public ProfileController(MyContext context)
        {
            db = context;
        }

        // ================= GET CURRENT USER ID =================
        private bool TryGetUserId(out int userId)
        {
            userId = 0;

            var claim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return int.TryParse(claim, out userId);
        }

        // ================= STUDENT PROFILE =================
        [Authorize(Roles = "Student")]
        [HttpGet("student")]
        public IActionResult GetStudentProfile()
        {
            if (!TryGetUserId(out int id))
                return Unauthorized("Invalid token");

            var student = db.Students
                .Where(x => x.Student_id == id)
                .Select(x => new
                {
                    x.Student_id,
                    x.St_Name,
                    x.Email,
                    x.Phone,
                    x.Department,
                    x.Gender
                })
                .FirstOrDefault();

            if (student == null)
                return NotFound("Student not found");

            return Ok(student);
        }

        // ================= PROFESSOR PROFILE =================
        [Authorize(Roles = "Professor")]
        [HttpGet("professor")]
        public IActionResult GetProfessorProfile()
        {
            if (!TryGetUserId(out int id))
                return Unauthorized("Invalid token");

            var professor = db.Professors
                .Where(x => x.Professor_id == id)
                .Select(x => new
                {
                    x.Professor_id,
                    x.Pro_Name,
                    x.Email,
                    x.Phone,
                    x.Department,
                    x.Gender
                })
                .FirstOrDefault();

            if (professor == null)
                return NotFound("Professor not found");

            return Ok(professor);
        }
    }
}