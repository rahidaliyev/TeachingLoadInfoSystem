namespace TeachingLoadInfoSystem.Models
{
    public class TeachinLoad : EntityBase
    {
        public TeachinLoad() 
        {
            Subjects = new List<Subject>(); 
        }
        public int TeacherInfoID { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string TeacherFather { get; set; }
        public DateTime SemesterTime { get; set; }
        public virtual List<Subject> Subjects {get;set;}
    }
}
