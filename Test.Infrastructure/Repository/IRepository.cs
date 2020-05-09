using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test.Infrastructure.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> UpdateAsync(T entity);
        Task<T> CreateAsync(T entity);
        Task DeleteByIdAsync(Guid id);
    }
}
