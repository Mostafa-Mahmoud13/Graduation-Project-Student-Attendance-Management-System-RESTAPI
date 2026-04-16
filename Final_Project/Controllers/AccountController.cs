using Final_Project.Context;
using Final_Project.DTO;
using Final_Project.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Final_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly MyContext db;

        public AccountController(MyContext context)
        {
            db = context;
        }

        // ================= SAFE JWT KEY =================
        private const string JwtKey = "THIS_IS_A_VERY_LONG_SECRET_KEY_1234567890";

        // ================= GENERATE TOKEN =================
        private string GenerateToken(Claim[] claims, int hours)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.UtcNow.AddHours(hours),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        // ================= STUDENT LOGIN =================
        [AllowAnonymous]
        [HttpPost("login-student")]
        public IActionResult LoginStudent([FromBody] LoginDTO model)
        {
            if (model == null)
                return BadRequest("Invalid request");

            var student = db.Students.FirstOrDefault(x => x.Email == model.Email);

            if (student == null)
                return Unauthorized("Email or Password wrong");

            if (!BCrypt.Net.BCrypt.Verify(model.Password, student.Password))
                return Unauthorized("Email or Password wrong");

            var token = GenerateToken(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, student.Student_id.ToString()),
                new Claim(ClaimTypes.Role, student.Role ?? "Student"),
                new Claim(ClaimTypes.Email, student.Email)
            }, 3);

            return Ok(new { token });
        }

        // ================= CHANGE STUDENT PASSWORD =================
        [Authorize]
        [HttpPost("change-password-student")]
        public async Task<IActionResult> ChangePasswordStudent([FromBody] ChangePasswordDTO model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (model.NewPassword != model.ConfirmPassword)
                return BadRequest("Password confirmation does not match");

            var studentId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!int.TryParse(studentId, out int id))
                return Unauthorized();

            var student = await db.Students.FindAsync(id);

            if (student == null)
                return NotFound();

            if (!BCrypt.Net.BCrypt.Verify(model.OldPassword, student.Password))
                return BadRequest("Old password incorrect");

            student.Password = BCrypt.Net.BCrypt.HashPassword(model.NewPassword);
            await db.SaveChangesAsync();

            return Ok("Password changed successfully");
        }

        // ================= PROFESSOR LOGIN =================
        [AllowAnonymous]
        [HttpPost("login-professor")]
        public IActionResult LoginProfessor([FromBody] LoginDTO model)
        {
            if (model == null)
                return BadRequest("Invalid data");

            var professor = db.Professors.FirstOrDefault(x => x.Email == model.Email);

            if (professor == null)
                return Unauthorized("Email or Password wrong");

            if (!BCrypt.Net.BCrypt.Verify(model.Password, professor.Password))
                return Unauthorized("Email or Password wrong");

            var token = GenerateToken(new[]
            {
                new Claim(ClaimTypes.NameIdentifier, professor.Professor_id.ToString()),
                new Claim(ClaimTypes.Role, "Professor")
            }, 3);

            return Ok(new
            {
                token,
                id = professor.Professor_id,
                name = professor.Pro_Name
            });
        }

        // ================= CHANGE PROFESSOR PASSWORD =================
        [Authorize(Roles = "Professor")]
        [HttpPost("change-password-professor")]
        public async Task<IActionResult> ChangePasswordProfessor([FromBody] ChangePasswordDTO model)
        {
            if (model.NewPassword != model.ConfirmPassword)
                return BadRequest("Password confirmation does not match");

            var professorId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (!int.TryParse(professorId, out int id))
                return Unauthorized();

            var professor = await db.Professors.FindAsync(id);

            if (professor == null)
                return NotFound();

            if (!BCrypt.Net.BCrypt.Verify(model.OldPassword, professor.Password))
                return BadRequest("Old password is incorrect");

            professor.Password = BCrypt.Net.BCrypt.HashPassword(model.NewPassword);
            await db.SaveChangesAsync();

            return Ok("Password changed successfully");
        }

        // ================= FORGOT PASSWORD =================
        [AllowAnonymous]
        [HttpPost("forgot-password")]
        public IActionResult ForgotPassword([FromBody] ForgotPasswordDTO model)
        {
            var student = db.Students.FirstOrDefault(x => x.Email == model.Email);
            var professor = db.Professors.FirstOrDefault(x => x.Email == model.Email);

            // always return same response (security fix)
            if (student == null && professor == null)
                return Ok("If email exists, reset link will be sent");

            var token = Guid.NewGuid().ToString();
            var expiry = DateTime.UtcNow.AddMinutes(30);

            if (student != null)
            {
                student.ResetToken = token;
                student.TokenExpiry = expiry;
            }
            else
            {
                professor.ResetToken = token;
                professor.TokenExpiry = expiry;
            }

            db.SaveChanges();

            var link = $"https://yourfrontend.com/reset-password?email={model.Email}&token={token}";
            Console.WriteLine(link);

            return Ok("If email exists, reset link will be sent");
        }

        // ================= RESET PASSWORD =================
        [AllowAnonymous]
        [HttpPost("reset-password")]
        public IActionResult ResetPassword([FromBody] ResetPasswordDTO model)
        {
            var student = db.Students.FirstOrDefault(x => x.Email == model.Email);
            var professor = db.Professors.FirstOrDefault(x => x.Email == model.Email);

            if (student == null && professor == null)
                return BadRequest("Invalid request");

            if (student != null)
            {
                if (student.ResetToken != model.Token || student.TokenExpiry < DateTime.UtcNow)
                    return BadRequest("Invalid or expired token");

                student.Password = BCrypt.Net.BCrypt.HashPassword(model.NewPassword);
                student.ResetToken = null;
                student.TokenExpiry = null;
            }
            else
            {
                if (professor.ResetToken != model.Token || professor.TokenExpiry < DateTime.UtcNow)
                    return BadRequest("Invalid or expired token");

                professor.Password = BCrypt.Net.BCrypt.HashPassword(model.NewPassword);
                professor.ResetToken = null;
                professor.TokenExpiry = null;
            }

            db.SaveChanges();

            return Ok("Password reset successful");
        }






        [AllowAnonymous]
        [HttpPost("fix-all-passwords")]
        public IActionResult FixAllPasswords()
        {
            var professors = db.Professors.ToList();
            var students = db.Students.ToList();

            foreach (var prof in professors)
            {
                if (!prof.Password.StartsWith("$2"))
                {
                    prof.Password = BCrypt.Net.BCrypt.HashPassword(prof.Password);
                }
            }

            foreach (var student in students)
            {
                if (!student.Password.StartsWith("$2"))
                {
                    student.Password = BCrypt.Net.BCrypt.HashPassword(student.Password);
                }
            }

            db.SaveChanges();
            
            return Ok("All passwords fixed successfully");
        }
    }
}