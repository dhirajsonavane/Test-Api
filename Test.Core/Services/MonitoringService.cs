using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.DTO;
using Test.Infrastructure.Repository;

namespace Test.Core.Services
{
    public class MonitoringService : IMonitoringService
    {
        private readonly IMapper _mapper;
        private readonly IMonitoringRepository _monitoringRepository;
        private readonly IVehicleTypeRepository _vehicleTypeRepository;

        public MonitoringService(IMapper mapper, IMonitoringRepository venueTypeRepository, IVehicleTypeRepository vehicleTypeRepository)
        {
            this._mapper = mapper;
            this._monitoringRepository = venueTypeRepository;
            this._vehicleTypeRepository = vehicleTypeRepository;
        }

        public Task<Monitoring> CreateAsync(Monitoring entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Monitoring> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Monitoring>> ListAsync()
        {
            var result = await _monitoringRepository.ListAsync();
            var trafficMonitoring = _mapper.Map<IEnumerable<Domain.Monitoring>, IEnumerable<DTO.Monitoring>>(result.OrderBy(m => m.ImageId));
            var vehicleTypes = await _vehicleTypeRepository.ListAsync();

            foreach (var item in result)
            {
                var vehicleTypeName = vehicleTypes.FirstOrDefault(i => i.Id == item.VehicleType).Name;
                var _tm = trafficMonitoring.FirstOrDefault(i => i.ImageId == item.ImageId);
                if (_tm != null)
                {
                    _tm.VehicleType = vehicleTypeName;
                }
            }

            return trafficMonitoring;
        }

        public Task<Monitoring> UpdateAsync(Monitoring entity)
        {
            throw new NotImplementedException();
        }
    }

}
