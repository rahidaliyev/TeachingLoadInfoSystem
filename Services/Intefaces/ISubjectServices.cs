using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface ISubjectServices
    {
        Subject GetSubjectByID(int id);
        void InsertSubject(Subject subject);
        void UpdateSubject(Subject subject);
        void DeleteSubject(int id);
        IEnumerable<Subject> GetAllSubjects();
    }
}
