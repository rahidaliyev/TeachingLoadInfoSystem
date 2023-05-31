using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class EducationPlanServices : IEducationPlanServices
    {
        private IRepository<EducationPlan> _repository;

        public EducationPlanServices(IRepository<EducationPlan> repository)
        {
            _repository = repository;
        }
        public EducationPlan GetEducationPlanByID(int id)
        {
            var selectedTeacher = _repository.GetAll
                  //.Include(x => x.SubjectID)
                .Include(x => x.Subjects)
                .FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertEducationPlan(EducationPlan educationPlan)
        {
            _repository.Insert(educationPlan);
        }
        public void UpdateEducationPlan(EducationPlan educationPlan)
        {
            _repository.Update(educationPlan);
        }
        public void DeleteEducationPlan(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<EducationPlan> GetAllEducationPlans()
        {
            return _repository

                .GetAll
                //.Include(x => x.SubjectID)
                .Include(x => x.Subjects)
                ;
        }
    }
}