namespace Final_Project.DTO
{
    public class UpdateStudentProfileDTO
    {
        public long ?Phone { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }

        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
