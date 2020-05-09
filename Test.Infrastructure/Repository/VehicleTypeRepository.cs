using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Test.Domain;

namespace Test.Infrastructure.Repository
{
    public class VehicleTypeRepository : IVehicleTypeRepository
    {
        private readonly Context context;

        public VehicleTypeRepository(Context context)
        {
            this.context = context;
        }

        public Task<VehicleType> CreateAsync(VehicleType entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<VehicleType>> ListAsync()
        {
            return await context.Set<Domain.VehicleType>().ToListAsync();
        }

        public async Task<VehicleType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<VehicleType> UpdateAsync(VehicleType entity)
        {
            throw new NotImplementedException();
        }
    }
}
