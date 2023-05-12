using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class SubjectServices : ISubjectServices
    {
        private IRepository<Subject> _repository;
        public SubjectServices(IRepository<Subject> repository)
        {
            _repository = repository;
        }
        public Subject GetSubjectByID(int id)
        {
            var selectedTeacher = _repository
                .GetAll
                .AsNoTracking()
                .FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertSubject(Subject subject)
        {
            _repository.Insert(subject);
        }
        public void UpdateSubject(Subject subject)
        {
            _repository.Update(subject);
        }
        public void DeleteSubject(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<Subject> GetAllSubjects()
        {
            return _repository.GetAll
                .AsNoTracking()
                ;
        }
    }
}
