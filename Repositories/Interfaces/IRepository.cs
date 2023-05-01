using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeachingLoadInfoSystem.Models;

namespace TeachingLoadInfoSystem.Repositories.Interfaces
{
    public interface IRepository<T> where T : EntityBase
    {
        T Get(T entity);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll { get; }
    }
}
