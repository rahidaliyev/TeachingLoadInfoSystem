namespace TeachingLoadInfoSystem.Models
{
    public class Group : EntityBase
    {
        public string? SpecialityCode { get; set; }
        public string? GroupName { get; set; }
        public string? GroupCourse { get; set; }
        public virtual Language? Language { get; set; }
        public int LanguageID { get; set; }
    }
}
