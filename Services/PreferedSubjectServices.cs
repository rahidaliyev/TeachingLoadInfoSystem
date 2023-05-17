using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class PreferedSubjectServices : IPreferedSubjectServices
    {
        private IRepository<PreferedSubject> _repository;

        public PreferedSubjectServices(IRepository<PreferedSubject> repository)
        {
            _repository = repository;
        }
        public PreferedSubject GetPreferedSubjectByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertPreferedSubject(PreferedSubject PreferedSubject)
        {
            _repository.Insert(PreferedSubject);
        }
        public void UpdatePreferedSubject(PreferedSubject PreferedSubject)
        {
            _repository.Update(PreferedSubject);
        }
        public void DeletePreferedSubject(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<PreferedSubject> GetAllPreferedSubjects()
        {
            return _repository.GetAll;
        }
    }
}
