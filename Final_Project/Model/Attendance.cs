using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Model
{
    public class Attendance
    {
        public int Id { get; set; }
        public bool Present { get; set; }
        public DateTime Date { get; set; }

        // FKs
        [ForeignKey("Student")]
        public int Student_Id { get; set; }
        [ForeignKey("Subject")]
        public int Subject_Id { get; set; }
        [ForeignKey("Professor")]
        public int Professor_Id { get; set; }

        // Navigation
        public Student Student { get; set; }
        public Subject Subject { get; set; }
        public Professor Professor { get; set; }

    }
}
