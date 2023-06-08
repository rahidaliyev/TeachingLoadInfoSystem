using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IGroupServices
    {
        Group GetGroupByID(int id);
        void InsertGroup(Group group);
        void UpdateGroup(Group group);
        void DeleteGroup(int id);
        IEnumerable<Group> GetAllGroups();
    }
}
