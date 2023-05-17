using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IProfessionServices
    {
        Profession GetProfessionByID(int id);
        void InsertProfession(Profession book);
        void UpdateProfession(Profession book);
        void DeleteProfession(int id);
        IEnumerable<Profession> GetAllProfessions();
    }
}
