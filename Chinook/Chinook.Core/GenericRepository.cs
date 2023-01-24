using Chinook.Core.Interface;
using Chinook.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Chinook.Core
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ChinookContext _context { get; set; }
        protected DbSet<T> _DbSet { get; set; }

        public GenericRepository(ChinookContext context)
        {
            _context = context;
            this._DbSet = context.Set<T>();
        }


        public virtual async Task<bool> AddEntity(T entity)
        {
            await _DbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<bool> DeleteEntity(long id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _DbSet.ToListAsync();
        }

        public virtual async Task<T> GetById(long id)
        {
            return await _DbSet.FindAsync(id);
        }

        public virtual async Task<bool> UpdateEntity(T entity)
        {
            throw new NotImplementedException();
        }
    }
}