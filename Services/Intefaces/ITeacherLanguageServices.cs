using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface ITeacherLanguageServices
    {
        TeacherLanguage GetTeacherLanguageByID(int id);
        void InsertTeacherLanguage(TeacherLanguage language);
        void UpdateTeacherLanguage(TeacherLanguage language);
        void DeleteTeacherLanguage(int id);
        IEnumerable<TeacherLanguage> GetAllTeacherLanguages();
    }
}
