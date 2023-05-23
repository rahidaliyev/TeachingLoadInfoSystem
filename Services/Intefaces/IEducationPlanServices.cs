using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IEducationPlanServices
    {
        EducationPlanGridForm GetEducationPlanByID(int id);
        void InsertEducationPlan(EducationPlanGridForm plan);
        void UpdateEducationPlan(EducationPlanGridForm plan);
        void DeleteEducationPlan(int id);
        IEnumerable<EducationPlanGridForm> GetAllEducationPlans();
    }
}
