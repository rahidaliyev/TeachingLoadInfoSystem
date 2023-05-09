using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Interfaces;

namespace TeachingLoadInfoSystem.Services
{
    public class LayoutServices : ILayoutServices
    {
        private IRepository<LayoutInfo> _repository;
        public LayoutServices(IRepository<LayoutInfo> repository)
        {
            _repository = repository;
        }
        public LayoutInfo GetLayoutByID(int id)
        {
            var selectedLayoutInfo = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedLayoutInfo;
        }
        public LayoutInfo GetLayoutByUserIDGridNameFormName(int userID, string gridName, string formName)
        {
            var searchedLayout = _repository.GetAll
                .Where(x => x.UserID == userID)
                .Where(x => x.GridName == gridName)
                .Where(x => x.FormName == formName)
                .FirstOrDefault();
            return searchedLayout;
        }
        public void InsertLayout(LayoutInfo layoutInfo)
        {
            _repository.Insert(layoutInfo);
        }
        public void UpdateLayout(LayoutInfo layoutInfo)
        {
            _repository.Update(layoutInfo);
        }
        public void DeleteLayout(int id)
        {
            var selectedLayoutInfo = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedLayoutInfo);
        }
        public IEnumerable<LayoutInfo> GetAllLayouts()
        {
            return _repository.GetAll;
        }
    }
}