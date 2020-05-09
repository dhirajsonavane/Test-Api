using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Domain;

namespace Test.Infrastructure.Repository
{
    public class MonitoringRepository : IMonitoringRepository
    {
        private readonly Context context;

        public MonitoringRepository(Context context)
        {
            this.context = context;
        }

        public Task<Monitoring> CreateAsync(Monitoring entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Monitoring>> ListAsync()
        {
            return await context.Set<Domain.Monitoring>().ToListAsync();
        }

        public Task<Monitoring> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Monitoring> UpdateAsync(Monitoring entity)
        {
            throw new NotImplementedException();
        }
    }
}
