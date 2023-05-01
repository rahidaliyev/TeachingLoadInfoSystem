namespace TeachingLoadInfoSystem.Models
{
    public class PreviousJob : EntityBase
    {
        public int TeacherInfoID { get; set; }
        public string? JobName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
