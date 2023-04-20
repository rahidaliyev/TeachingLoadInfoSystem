using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1.Services
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
            var selectedTeacher = _repository.GetAll.AsNoTracking().FirstOrDefault(x => x.ID == id);
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
            return _repository.GetAll.AsNoTracking();
        }
    }
}
