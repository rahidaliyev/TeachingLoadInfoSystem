using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1.Services
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
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
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
            return _repository.GetAll;
        }
    }
}
