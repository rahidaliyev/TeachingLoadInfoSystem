using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services.Intefaces
{
    public interface ILanguageServices
    {
        Language GetLanguageByID(int id);
        void InsertLanguage(Language language);
        void UpdateLanguage(Language language);
        void DeleteLanguage(int id);
        IEnumerable<Language> GetAllLanguages();
    }
}
