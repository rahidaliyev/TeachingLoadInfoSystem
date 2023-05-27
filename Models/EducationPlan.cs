namespace TeachingLoadInfoSystem.Models
{
    public class EducationPlan : EntityBase
    {
        public string SpecialityCode { get; set; }
        public virtual Subject? Subjects { get; set; }
        public int SubjectID { get; set; }
        public int CreditCount { get; set; }
        public int TotalHours { get; set; }
        public int OutsideAuditoriumHours { get; set; }
        public int AuditoriumHours { get; set; }
        public int LectureHours { get; set; }
        public int SeminarHours { get; set; }
        public int LaboratoryHours { get; set; }
        //public virtual Subject? PrerekvizitSubjects { get; set; }
        //public int PrerekvizitSubjectsID { get; set; }
        //public virtual Subject? KorrekvizitSubjects { get; set; }
        //public int KorrekvizitSubjectsID { get; set; }
        public string Semestr { get; set; } 
        public int WeeklyCourseLoad { get; set; }
    }
}
