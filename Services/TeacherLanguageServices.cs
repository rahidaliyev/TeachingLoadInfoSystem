using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class TeacherLanguageServices : ITeacherLanguageServices
    {
        private IRepository<TeacherLanguage> _repository;

        public TeacherLanguageServices(IRepository<TeacherLanguage> repository)
        {
            _repository = repository;
        }
        public TeacherLanguage GetTeacherLanguageByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertTeacherLanguage(TeacherLanguage TeacherLanguage)
        {
            _repository.Insert(TeacherLanguage);
        }
        public void UpdateTeacherLanguage(TeacherLanguage TeacherLanguage)
        {
            _repository.Update(TeacherLanguage);
        }
        public void DeleteTeacherLanguage(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<TeacherLanguage> GetAllTeacherLanguages()
        {
            return _repository.GetAll;
        }
    }
}
