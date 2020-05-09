using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteByIdAsync(Guid id);
    }
}
