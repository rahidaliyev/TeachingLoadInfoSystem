using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class ProfessionServices : IProfessionServices
    {
        private IRepository<Profession> _repository;

        public ProfessionServices(IRepository<Profession> repository)
        {
            _repository = repository;
        }
        public Profession GetProfessionByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertProfession(Profession Profession)
        {
            _repository.Insert(Profession);
        }
        public void UpdateProfession(Profession Profession)
        {
            _repository.Update(Profession);
        }
        public void DeleteProfession(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<Profession> GetAllProfessions()
        {
            return _repository.GetAll;
        }
    }
}
