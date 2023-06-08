using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class EducationPlanPerGroupServices : IEducationPlanPerGroupServices
    {
        private IRepository<EducationPlanPerGroup> _repository;

        public EducationPlanPerGroupServices(IRepository<EducationPlanPerGroup> repository)
        {
            _repository = repository;
        }
        public EducationPlanPerGroup GetEducationPlanPerGroupByID(int id)
        {
            var selectedTeacher = _repository.GetAll
                .Include(x => x.Subject)
                .FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertEducationPlanPerGroup(EducationPlanPerGroup EducationPlanPerGroup)
        {
            _repository.Insert(EducationPlanPerGroup);
        }
        public void UpdateEducationPlanPerGroup(EducationPlanPerGroup EducationPlanPerGroup)
        {
            _repository.Update(EducationPlanPerGroup);
        }
        public void DeleteEducationPlanPerGroup(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<EducationPlanPerGroup> GetAllEducationPlanPerGroups()
        {
            return _repository.GetAll.Include(x => x.Subject);
        }
    }
}
