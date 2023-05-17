using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class TLExcludedServices : ITLExcludedServices
    {
        private IRepository<TLExcluded> _repository;

        public TLExcludedServices(IRepository<TLExcluded> repository)
        {
            _repository = repository;
        }
        public TLExcluded GetTLExcludedByID(int id)
        {
            var selectedTeacher = _repository
                .GetAll
                .Include(x => x.Department)
                .FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertTLExcluded(TLExcluded included)
        {
            _repository.Insert(included);
        }
        public void UpdateTLExcluded(TLExcluded included)
        {
            _repository.Update(included);
        }
        public void DeleteTLExcluded(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<TLExcluded> GetAllTLExcludeds()
        {
            return _repository.GetAll
                .Include(x => x.Department)
                ;
        }
    }
}
