using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class TeachingLoadServices : ITeachingLoadServices
    {
        private IRepository<TeachingLoad> _repository;

        public TeachingLoadServices(IRepository<TeachingLoad> repository)
        {
            _repository = repository;
        }
        public TeachingLoad GetTeachingLoadByID(int id)
        {
            var selectedTeacher = _repository
                .GetAll
                .Include(x => x.TeachingLoadSubjects)
                .Include(x => x.TeachingLoadSubjects).ThenInclude(y => y.Subjects)
                .AsNoTracking()
                .FirstOrDefault(x => x.ID == id)
                ;
            return selectedTeacher;
        }
        public void InsertTeachingLoad(TeachingLoad TeachingLoad)
        {
            _repository.Insert(TeachingLoad);
        }
        public void UpdateTeachingLoad(TeachingLoad TeachingLoad)
        {
            _repository.Update(TeachingLoad);
        }
        public void DeleteTeachingLoad(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<TeachingLoad> GetAllTeachingLoads()
        {
            return _repository
                .GetAll
                .Include(x => x.TeachingLoadSubjects)
                .Include(x => x.TeachingLoadSubjects).ThenInclude(y => y.Subjects)
                .AsNoTracking()
                ;
        }
    }
}
