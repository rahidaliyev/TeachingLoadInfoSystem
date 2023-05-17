namespace TeachingLoadInfoSystem.Models
{
    public class TeachingLoad : EntityBase
    {
        public TeachingLoad()
        {
            TeachingLoadSubjects = new List<TeachingLoadSubject>();
        }
        public int TeacherInfoID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string TeacherFather { get; set; }
        public DateTime SemesterTime { get; set; }
        public virtual List<TeachingLoadSubject> TeachingLoadSubjects { get; set; }
    }
}
