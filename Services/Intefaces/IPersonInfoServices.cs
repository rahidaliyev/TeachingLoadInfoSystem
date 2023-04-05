using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Services.Intefaces
{
    public interface IPersonInfoServices
    {
        PersonInfo GetPersonByID(int id);
        void InsertPerson(PersonInfo personinfo);
        void UpdatePerson(PersonInfo personinfo);
        void DeletePerson(int id);
        IEnumerable<PersonInfo> GetAllPersons();
    }
}
