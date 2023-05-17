using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface ITeachingLoadServices
    {
        TeachingLoad GetTeachingLoadByID(int id);
        void InsertTeachingLoad(TeachingLoad book);
        void UpdateTeachingLoad(TeachingLoad book);
        void DeleteTeachingLoad(int id);
        IEnumerable<TeachingLoad> GetAllTeachingLoads();
    }
}
