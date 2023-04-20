﻿using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1.Services
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
