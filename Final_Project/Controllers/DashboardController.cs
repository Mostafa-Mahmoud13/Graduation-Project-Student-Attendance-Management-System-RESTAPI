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
    public class DashboardController : ControllerBase
    {
        private readonly MyContext db;

        public DashboardController(MyContext context)
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

        // ================= STUDENT DASHBOARD =================
        [Authorize(Roles = "Student")]
        [HttpGet("dashboard-student")]
        public async Task<IActionResult> GetStudentDashboard()
        {
            if (!TryGetUserId(out int studentId))
                return Unauthorized(new { message = "Invalid token" });

            // attendance stats (FAST WAY)
            int total = await db.Attendances
                .CountAsync(a => a.Student_Id == studentId);

            int present = await db.Attendances
                .CountAsync(a => a.Student_Id == studentId && a.Present);

            double percentage = total == 0 ? 0 : (double)present / total * 100;

            var dashboard = new StudentDashboardDTO
            {
                TotalSubjects = await db.StudentSubjects
                    .CountAsync(s => s.Student_Id == studentId),

                AttendancePercentage = Math.Round(percentage, 2),

                IsWarning = percentage < 75
            };

            return Ok(dashboard);
        }

        // ================= PROFESSOR DASHBOARD =================
        [Authorize(Roles = "Professor")]
        [HttpGet("dashboard-professor")]
        public async Task<IActionResult> GetProfessorDashboard()
        {
            if (!TryGetUserId(out int professorId))
                return Unauthorized(new { message = "Invalid token" });

            var subjects = await db.Subjects
                .Where(s => s.Professor_Id == professorId)
                .ToListAsync();

            int totalSubjects = subjects.Count;

            var subjectIds = subjects.Select(s => s.Sub_ID).ToList();

            var now = DateTime.UtcNow;
            var today = now.Date;

            // ================= TODAY PRESENT =================
            var todayPresentStudents = await db.Attendances
                .Where(a => a.Professor_Id == professorId && a.Date.Date == today)
                .Select(a => a.Student_Id)
                .Distinct()
                .ToListAsync();

            int todayPresent = todayPresentStudents.Count;

            // ================= TOTAL STUDENTS =================
            int totalStudents = await db.StudentSubjects
                .Where(ss => ss.Subject != null && subjectIds.Contains(ss.Subject_Id ?? 0))
                .Select(ss => ss.Student_Id)
                .Distinct()
                .CountAsync();

            // ================= ABSENT =================
            int todayAbsent = totalStudents - todayPresent;

            var dashboard = new ProfessorDashboardDTO
            {
                TotalStudents = totalStudents,
                TotalSubjects = totalSubjects,
                TodayAttendance = todayPresent,
                TodayAbsent = todayAbsent
            };

            return Ok(dashboard);
        }
    }
}