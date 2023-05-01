using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IPreviousJobServices
    {
        PreviousJob GetPreviousJobByID(int id);
        void InsertPreviousJob(PreviousJob previousJob);
        void UpdatePreviousJob(PreviousJob previousJob);
        void DeletePreviousJob(int id);
        IEnumerable<PreviousJob> GetAllPreviousJobs();
    }
}
