namespace TeachingLoadInfoSystem.Models
{
    public class PreferedSubject : EntityBase
    {
        public int TeacherInfoID { get; set; }
        public Subject? Subject { get; set; }
        public int SubjectID { get; set; }
    }
}
