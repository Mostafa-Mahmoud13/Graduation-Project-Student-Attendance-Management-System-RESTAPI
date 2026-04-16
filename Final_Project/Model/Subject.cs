using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final_Project.Model
{
    public class Subject
    {
        public Subject()
        {
            StudentSubjects = new HashSet<StudentSubject>();
            Attendances = new HashSet<Attendance>();
        }

        [Key]
        public int Sub_ID { get; set; }
        public string Sub_Name { get; set; }
        public string Sub_Code { get; set; }

        [ForeignKey("Professor")]
        public int ?Professor_Id { get; set; }
        public Professor Professor { get; set; }

        public ICollection<StudentSubject> StudentSubjects { get; set; }
        public ICollection<Attendance> Attendances { get; set; }
    }
}
