using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class EducationPlanServices : IEducationPlanServices
    {
        private IRepository<EducationPlanGridForm> _repository;

        public EducationPlanServices(IRepository<EducationPlanGridForm> repository)
        {
            _repository = repository;
        }
        public EducationPlanGridForm GetEducationPlanByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertEducationPlan(EducationPlanGridForm EducationPlan)
        {
            _repository.Insert(EducationPlan);
        }
        public void UpdateEducationPlan(EducationPlanGridForm EducationPlan)
        {
            _repository.Update(EducationPlan);
        }
        public void DeleteEducationPlan(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<EducationPlanGridForm> GetAllEducationPlans()
        {
            return _repository.GetAll;
        }
    }
}
