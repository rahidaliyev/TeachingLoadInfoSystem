using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.AppDbContext;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories.Interfaces;

namespace WindowsFormsApp1.Repositories
{
    public class Repository<T> : IRepository<T> where T : EntityBase
    {
        private readonly TLDbContext _context;
        private DbSet<T> _entities;

        public Repository(TLDbContext context)
        {
            this._context = context;
        }

        public T Get(T entity)
        {
            return this.Entities.Find(entity);
        }

        public void Insert(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Add(entity);
                this._context.SaveChanges();
            }
            catch (Exception)
            {
                throw; 
            }
        }

        public void Update(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                Entities.Update(entity);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw; 
            }
        }

        public void Delete(T entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.Entities.Remove(entity);
                this._context.SaveChanges();
            }
            catch (Exception)
            {
                throw; 
            }
        }

        public virtual IQueryable<T> GetAll
        {
            get
            {
                return this.Entities;
            }
        }

        private DbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }
    }
}
