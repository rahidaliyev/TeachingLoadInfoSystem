using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IPreferedSubjectServices
    {
        PreferedSubject GetPreferedSubjectByID(int id);
        void InsertPreferedSubject(PreferedSubject book);
        void UpdatePreferedSubject(PreferedSubject book);
        void DeletePreferedSubject(int id);
        IEnumerable<PreferedSubject> GetAllPreferedSubjects();
    }
}
