using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class PreviousJobServices : IPreviousJobServices
    {
        private IRepository<PreviousJob> _repository;
        public PreviousJobServices(IRepository<PreviousJob> repository)
        {
            _repository = repository;
        }
        public PreviousJob GetPreviousJobByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertPreviousJob(PreviousJob PreviousJob)
        {
            _repository.Insert(PreviousJob);
        }
        public void UpdatePreviousJob(PreviousJob PreviousJob)
        {
            _repository.Update(PreviousJob);
        }
        public void DeletePreviousJob(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<PreviousJob> GetAllPreviousJobs()
        {
            return _repository.GetAll;
        }
    }
}
