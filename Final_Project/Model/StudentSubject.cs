namespace Final_Project.Model
{
    public class StudentSubject
    {
        public int ?Student_Id { get; set; }
        public Student Student { get; set; }

        public int ?Subject_Id { get; set; }
        public Subject Subject { get; set; }
    }
}
