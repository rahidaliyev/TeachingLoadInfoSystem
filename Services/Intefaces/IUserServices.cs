using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IUserServices
    {
        User GetUserByID(int id);
        void InsertUser(User book);
        void UpdateUser(User book);
        void DeleteUser(int id);
        IEnumerable<User> GetAllUsers();
    }
}
