using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface ITLIncludedServices
    {
        TLIncluded GetTLIncludedByID(int id);
        void InsertTLIncluded(TLIncluded included);
        void UpdateTLIncluded(TLIncluded included);
        void DeleteTLIncluded(int id);
        IEnumerable<TLIncluded> GetAllTLIncludeds();
    }
}
