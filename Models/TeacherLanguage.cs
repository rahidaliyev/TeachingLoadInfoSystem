namespace TeachingLoadInfoSystem.Models
{
    public class TeacherLanguage : EntityBase
    {
        public TeacherLanguage() 
        {
            Language = new Language();
        }
        public int TeacherInfoID { get; set; }
        public virtual Language? Language { get; set; }
        public int LanguageID { get; set; }
        public int PreferenceLevel { get; set; }
    }
}
