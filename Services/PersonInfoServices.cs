using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories.Interfaces;
using WindowsFormsApp1.Services.Intefaces;

namespace WindowsFormsApp1.Services
{
    public class PersonInfoServices : IPersonInfoServices
    {
        private IRepository<PersonInfo> _repository;
        public PersonInfoServices(IRepository<PersonInfo> repository)
        {
            _repository = repository;
        }
        public PersonInfo GetPersonByID(int id)
        {
            var selectedPerson = _repository.GetAll.AsNoTracking().FirstOrDefault(x => x.ID == id);
            return selectedPerson;
        }
        public void InsertPerson(PersonInfo personinfo)
        {
            _repository.Insert(personinfo);
        }
        public void UpdatePerson(PersonInfo personinfo)
        {
            _repository.Update(personinfo);
        }
        public void DeletePerson(int id)
        {
            var selectedPerson = _repository.GetAll.FirstOrDefault(x => x.ID == id);
            _repository.Delete(selectedPerson);
        }
        public IEnumerable<PersonInfo> GetAllPersons()
        {
            return _repository.GetAll.AsNoTracking();
        }
    }
}
