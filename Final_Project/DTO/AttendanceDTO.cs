namespace Final_Project.DTO
{
    public class AttendanceDTO
    {
        public int SubjectId { get; set; }
        public DateTime Date { get; set; }
        public List<AttendanceItemDTO> Students { get; set; }
    }

    public class AttendanceItemDTO
    {
        public int StudentId { get; set; }
        public bool Present { get; set; }
    }
}
