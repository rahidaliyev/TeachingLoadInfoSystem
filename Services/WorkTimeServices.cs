using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class WorkTimeServices : IWorkTimeServices
    {
        private IRepository<WorkTime> _repository;
        public WorkTimeServices(IRepository<WorkTime> repository)
        {
            _repository = repository;
        }
        public WorkTime GetWorkTimeByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertWorkTime(WorkTime workTime)
        {
            _repository.Insert(workTime);
        }
        public void UpdateWorkTime(WorkTime workTime)
        {
            _repository.Update(workTime);
        }
        public void DeleteWorkTime(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<WorkTime> GetAllWorkTimes()
        {
            return _repository.GetAll;
        }
    }
}
