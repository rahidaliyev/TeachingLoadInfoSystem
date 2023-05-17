using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface ITLExcludedServices
    {
        TLExcluded GetTLExcludedByID(int id);
        void InsertTLExcluded(TLExcluded included);
        void UpdateTLExcluded(TLExcluded included);
        void DeleteTLExcluded(int id);
        IEnumerable<TLExcluded> GetAllTLExcludeds();
    }
}
