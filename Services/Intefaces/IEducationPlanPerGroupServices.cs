using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IEducationPlanPerGroupServices
    {
        EducationPlanPerGroup GetEducationPlanPerGroupByID(int id);
        void InsertEducationPlanPerGroup(EducationPlanPerGroup EducationPlanPerGroup);
        void UpdateEducationPlanPerGroup(EducationPlanPerGroup EducationPlanPerGroup);
        void DeleteEducationPlanPerGroup(int id);
        IEnumerable<EducationPlanPerGroup> GetAllEducationPlanPerGroups();
    }
}
