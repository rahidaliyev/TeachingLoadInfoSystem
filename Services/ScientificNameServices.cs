using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1.Services
{
    public class ScientificNameServices : IScientificNameServices
    {
        private IRepository<ScientificName> _repository;
        public ScientificNameServices(IRepository<ScientificName> repository)
        {
            _repository = repository;
        }
        public ScientificName GetScientificNameByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertScientificName(ScientificName ScientificName)
        {
            _repository.Insert(ScientificName);
        }
        public void UpdateScientificName(ScientificName ScientificName)
        {
            _repository.Update(ScientificName);
        }
        public void DeleteScientificName(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<ScientificName> GetAllScientificNames()
        {
            return _repository.GetAll;
        }
    }
}
