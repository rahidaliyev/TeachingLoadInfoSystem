using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services.Intefaces
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
