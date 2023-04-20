using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services.Intefaces
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
