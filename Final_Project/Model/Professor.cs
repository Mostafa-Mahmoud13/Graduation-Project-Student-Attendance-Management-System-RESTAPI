using System.ComponentModel.DataAnnotations;

namespace Final_Project.Model
{
    public class Professor
    {
        public Professor()
        {
            Subjects = new HashSet<Subject>();
            Attendances = new HashSet<Attendance>();
        }
        [Key]
        public int Professor_id { get; set; }
        //==============================
        public string Pro_Name { get; set; }
        //==============================
        public int Pro_code { get; set; }
        //==============================
        public string Gender { get; set; }
        //==============================
        public string Department { get; set; }
        //==============================
        [EmailAddress]
        public string Email { get; set; } = "mail@example.com";
        //==============================
        [Required(ErrorMessage = "*")]

        [DataType(DataType.Password)]
        public string Password { get; set; }
        //==============================
        public string Role { get; set; } = "Professor";
        public long? Phone { get; set; }
        //==============================
        public string? ResetToken { get; set; }
        public DateTime? TokenExpiry { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Attendance> Attendances { get; set; }


    }
}
