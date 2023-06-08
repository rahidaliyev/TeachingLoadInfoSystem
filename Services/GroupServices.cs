using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class GroupServices : IGroupServices
    {
        private IRepository<Group> _repository;

        public GroupServices(IRepository<Group> repository)
        {
            _repository = repository;
        }
        public Group GetGroupByID(int id)
        {
            var selectedGroup = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedGroup;
        }
        public void InsertGroup(Group Group)
        {
            _repository.Insert(Group);
        }
        public void UpdateGroup(Group Group)
        {
            _repository.Update(Group);
        }
        public void DeleteGroup(int id)
        {
            var selectedGroup = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedGroup);
        }
        public IEnumerable<Group> GetAllGroups()
        {
            return _repository.GetAll;
        }
    }
}
