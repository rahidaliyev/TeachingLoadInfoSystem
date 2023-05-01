using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IWorkTimeServices
    {
        WorkTime GetWorkTimeByID(int id);
        void InsertWorkTime(WorkTime workTime);
        void UpdateWorkTime(WorkTime workTime);
        void DeleteWorkTime(int id);
        IEnumerable<WorkTime> GetAllWorkTimes();
    }
}
