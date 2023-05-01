using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class TeacherInfoServices : ITeacherInfoServices
    {
        private IRepository<TeacherInfo> _repository;
        public TeacherInfoServices(IRepository<TeacherInfo> repository)
        {
            _repository = repository;
        }
        public TeacherInfo GetTeacherInfoByID(int id)
        {
            var selectedTeacher = _repository.GetAll
                .Include(x => x.Gender)
                .Include(x => x.Department)
                .Include(x => x.ScientificName)
                .Include(x => x.ScientificDegree)
                .Include(x => x.WorkTime)
                .AsNoTracking().FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertTeacherInfo(TeacherInfo teacherInfo)
        {
            _repository.Insert(teacherInfo);
        }
        public void UpdateTeacherInfo(TeacherInfo teacherInfo)
        {
            _repository.Update(teacherInfo);
        }
        public void DeleteTeacherInfo(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<TeacherInfo> GetAllTeacherInfos()
        {
            return _repository.GetAll
                .Include(x => x.Gender)
                .Include(x => x.Department)
                .Include(x => x.ScientificName)
                .Include(x => x.ScientificDegree)
                .Include(x => x.WorkTime)
                .AsNoTracking();
        }
    }
}
