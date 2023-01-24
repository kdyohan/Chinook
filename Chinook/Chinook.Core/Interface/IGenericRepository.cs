using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Core.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(long id);
        Task<bool> AddEntity(T entity);
        Task<bool> DeleteEntity(long id);
        Task<bool> UpdateEntity(T entity);
    }
}
