namespace TeachingLoadInfoSystem.Models
{
    public class TeacherInfo : EntityBase
    {
        public TeacherInfo()
        {
            Gender = new Gender();
            ScientificName = new ScientificName();
            Department = new Department();
            WorkTime = new WorkTime();
            Books = new List<Book>();
            Certificates = new List<Certificate>();
            PreviousJobs = new List<PreviousJob>();
            TeacherLanguages = new List<TeacherLanguage>();
        }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string TeacherFather { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public virtual Gender? Gender { get; set; }
        public int GenderID { get; set; }
        public virtual ScientificName? ScientificName { get; set; }
        public int ScientificNameID { get; set; }
        public virtual ScientificDegree? ScientificDegree { get; set; }
        public int ScientificDegreeID { get; set; }
        public virtual Department? Department { get; set; }
        public int DepartmentID { get; set; }
        public virtual WorkTime? WorkTime { get; set; }
        public int WorkTimeID { get; set; }
        public virtual List<Book>? Books { get; set; }
        public virtual List<Certificate>? Certificates { get; set; }
        public virtual List<PreviousJob>? PreviousJobs { get; set; }
        public virtual List<TeacherLanguage>? TeacherLanguages { get; set; }
    }
}
