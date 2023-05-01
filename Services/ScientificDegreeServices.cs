using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class ScientificDegreeServices : IScientificDegreeServices
    {
        private IRepository<ScientificDegree> _repository;
        public ScientificDegreeServices(IRepository<ScientificDegree> repository)
        {
            _repository = repository;
        }
        public ScientificDegree GetScientificDegreeByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertScientificDegree(ScientificDegree scientificDegree)
        {
            _repository.Insert(scientificDegree);
        }
        public void UpdateScientificDegree(ScientificDegree scientificDegree)
        {
            _repository.Update(scientificDegree);
        }
        public void DeleteScientificDegree(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<ScientificDegree> GetAllScientificDegrees()
        {
            return _repository.GetAll;
        }
    }
}
