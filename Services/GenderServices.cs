using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class GenderServices : IGenderServices
    {
        private IRepository<Gender> _repository;
        public GenderServices(IRepository<Gender> repository)
        {
            _repository = repository;
        }
        public Gender GetGenderByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertGender(Gender Gender)
        {
            _repository.Insert(Gender);
        }
        public void UpdateGender(Gender Gender)
        {
            _repository.Update(Gender);
        }
        public void DeleteGender(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<Gender> GetAllGenders()
        {
            return _repository.GetAll;
        }
    }
}
