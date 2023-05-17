using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface ITeachingLoadSubjectServices
    {
        TeachingLoadSubject GetTeachingLoadSubjectByID(int id);
        void InsertTeachingLoadSubject(TeachingLoadSubject book);
        void UpdateTeachingLoadSubject(TeachingLoadSubject book);
        void DeleteTeachingLoadSubject(int id);
        IEnumerable<TeachingLoadSubject> GetAllTeachingLoadSubjects();
    }
}
