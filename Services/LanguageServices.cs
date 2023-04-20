using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1.Services
{
    public class LanguageServices : ILanguageServices
    {
        private IRepository<Language> _repository;
        public LanguageServices(IRepository<Language> repository)
        {
            _repository = repository;
        }
        public Language GetLanguageByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertLanguage(Language Language)
        {
            _repository.Insert(Language);
        }
        public void UpdateLanguage(Language Language)
        {
            _repository.Update(Language);
        }
        public void DeleteLanguage(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<Language> GetAllLanguages()
        {
            return _repository.GetAll;
        }
    }
}
