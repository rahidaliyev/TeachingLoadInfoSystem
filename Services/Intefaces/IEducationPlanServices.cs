using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IEducationPlanServices
    {
        EducationPlan GetEducationPlanByID(int id);
        void InsertEducationPlan(EducationPlan plan);
        void UpdateEducationPlan(EducationPlan plan);
        void DeleteEducationPlan(int id);
        IEnumerable<EducationPlan> GetAllEducationPlans();
    }
}
