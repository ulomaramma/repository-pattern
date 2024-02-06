using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Core.Repositories
{
    public class GenericRepository<T> : IGenerericRepository<T> where T : class
    {
        protected readonly ApplicationDBContext _dbContext;
        private DbSet<T> _entities;

        /// <summary>
        /// Inject DB conext 
        /// </summary>
        /// <param name="dbContext"></param>
        public GenericRepository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<T>();

        }
        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            _entities.AddRange(entities);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _entities.RemoveRange(entities);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _entities.Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.Find(id);
        }

       
    }
}
