using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class TeachingLoadSubjectServices : ITeachingLoadSubjectServices
    {
        private IRepository<TeachingLoadSubject> _repository;

        public TeachingLoadSubjectServices(IRepository<TeachingLoadSubject> repository)
        {
            _repository = repository;
        }
        public TeachingLoadSubject GetTeachingLoadSubjectByID(int id)
        {
            var selectedTeacher = _repository
                .GetAll.Include(x=>x.Subjects)
                .FirstOrDefault(x => x.ID == id)
                ;
            return selectedTeacher;
        }
        public void InsertTeachingLoadSubject(TeachingLoadSubject TeachingLoadSubject)
        {
            _repository.Insert(TeachingLoadSubject);
        }
        public void UpdateTeachingLoadSubject(TeachingLoadSubject TeachingLoadSubject)
        {
            _repository.Update(TeachingLoadSubject);
        }
        public void DeleteTeachingLoadSubject(int id)
        {
            var selectedTeacher = _repository.GetAll.Include(x=>x.Subjects).FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<TeachingLoadSubject> GetAllTeachingLoadSubjects()
        {
            return _repository
                .GetAll.Include(x=>x.Subjects)
                ;
        }
    }
}
