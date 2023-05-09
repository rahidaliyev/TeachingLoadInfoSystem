using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Interfaces
{
    public interface ILayoutServices
    {
        LayoutInfo GetLayoutByID(int id);
        LayoutInfo GetLayoutByUserIDGridNameFormName(int UserID, string GridName, string FormName);
        void InsertLayout(LayoutInfo layoutInfo);
        void UpdateLayout(LayoutInfo layoutInfo);
        void DeleteLayout(int id);
        IEnumerable<LayoutInfo> GetAllLayouts();
    }
}