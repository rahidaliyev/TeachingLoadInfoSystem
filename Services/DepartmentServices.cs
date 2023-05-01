using Microsoft.EntityFrameworkCore;
using TeachingLoadInfoSystem.Models;
using TeachingLoadInfoSystem.Repositories.Interfaces;
using TeachingLoadInfoSystem.Services.Intefaces;

namespace TeachingLoadInfoSystem.Services
{
    public class DepartmentServices : IDepartmentServices
    {
        private IRepository<Department> _repository;
        public DepartmentServices(IRepository<Department> repository)
        {
            _repository = repository;
        }
        public Department GetDepartmentByID(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            return selectedTeacher;
        }
        public void InsertDepartment(Department Department)
        {
            _repository.Insert(Department);
        }
        public void UpdateDepartment(Department Department)
        {
            _repository.Update(Department);
        }
        public void DeleteDepartment(int id)
        {
            var selectedTeacher = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedTeacher);
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _repository.GetAll;
        }
    }
}
