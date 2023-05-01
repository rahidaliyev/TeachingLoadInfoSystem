using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IGenderServices
    {
        Gender GetGenderByID(int id);
        void InsertGender(Gender gender);
        void UpdateGender(Gender gender);
        void DeleteGender(int id);
        IEnumerable<Gender> GetAllGenders();
    }
}
