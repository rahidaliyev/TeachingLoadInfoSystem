namespace TeachingLoadInfoSystem.Models
{
    public class TeachingLoadSubject : EntityBase
    {
        public int TeachingLoadID { get; set; }
        public string? SpecialityCode { get; set; }
        public virtual Subject? Subjects { get; set; }
        public int SubjectID { get; set; }
        public int CreditCount { get; set; }
        public int TotalHours { get; set; }
        public int OutsideAuditoriumHours { get; set; }
        public int AuditoriumHours { get; set; }
        public int LectureHours { get; set; }
        public int SeminarHours { get; set; }
        public int LaboratoryHours { get; set; }
        public string? Semestr { get; set; }
        public int WeeklyCourseLoad { get; set; }
        public string? GroupName { get; set; }
        public string? GroupCourse { get; set; }
        public int LanguageID { get; set; }
        public int EducationPlanPerGroupID { get; set; } 
    }
}
