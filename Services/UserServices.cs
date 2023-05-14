using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class UserServices : IUserServices
    {
        private IRepository<User> _repository;

        public UserServices(IRepository<User> repository)
        {
            _repository = repository;
        }
        public User GetUserByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertUser(User User)
        {
            _repository.Insert(User);
        }
        public void UpdateUser(User User)
        {
            _repository.Update(User);
        }
        public void DeleteUser(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _repository.GetAll;
        }
    }
}
