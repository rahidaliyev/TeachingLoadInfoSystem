namespace TeachingLoadInfoSystem.Models
{
    public class TeachingLoad : EntityBase
    {
        public TeachingLoad()
        {
            TeachingLoadSubjects = new List<TeachingLoadSubject>();
        }
        public int TeacherInfoID { get; set; }
        public string TeacherFullName { get; set; }
        public string SemesterTime { get; set; }
        public virtual List<TeachingLoadSubject> TeachingLoadSubjects { get; set; }
    }
}
