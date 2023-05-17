using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class TLIncludedServices : ITLIncludedServices
    {
        private IRepository<TLIncluded> _repository;

        public TLIncludedServices(IRepository<TLIncluded> repository)
        {
            _repository = repository;
        }
        public TLIncluded GetTLIncludedByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertTLIncluded(TLIncluded included)
        {
            _repository.Insert(included);
        }
        public void UpdateTLIncluded(TLIncluded included)
        {
            _repository.Update(included);
        }
        public void DeleteTLIncluded(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<TLIncluded> GetAllTLIncludeds()
        {
            return _repository.GetAll;
        }
    }
}
