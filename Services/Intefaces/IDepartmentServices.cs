using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services.Intefaces
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
