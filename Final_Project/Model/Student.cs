using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Final_Project.Model
{
    public class Student
    {
        public Student()
        {
            StudentSubjects = new HashSet<StudentSubject>();
            Attendances = new HashSet<Attendance>();
        }

        [Key]
        public int Student_id { get; set; }
        public string St_Name { get; set; }
        [EmailAddress]
        public string Email { get; set; } = "mail@example.com";
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Role { get; set; } = "Student";
        public long? Phone { get; set; }
        public string? Department { get; set; }
        [Required]
        public int St_code { get; set; }
        public string? Gender { get; set; }
        public string? ResetToken { get; set; }
        public DateTime? TokenExpiry { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
        public ICollection<Attendance> Attendances { get; set; }

    }
}
