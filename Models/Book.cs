namespace TeachingLoadInfoSystem.Models
{
    public class Book : EntityBase
    {
        public int TeacherInfoID { get; set; }
        public string? BookName { get; set; }
        public bool IsTextBook { get; set; }
    }
}
