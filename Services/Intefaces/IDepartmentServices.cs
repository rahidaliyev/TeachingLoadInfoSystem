using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Services.Intefaces
{
    public interface IDepartmentServices
    {
        Department GetDepartmentByID(int id);
        void InsertDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int id);
        IEnumerable<Department> GetAllDepartments();
    }
}
