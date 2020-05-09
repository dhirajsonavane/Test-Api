using Moq;
using System.Collections.Generic;
using Test.Infrastructure.Repository;

namespace Test.Test
{
    public static class VehicleTypeTestBase
    {
        public static Mock<IVehicleTypeRepository> ListAsync()
        {
            Mock<IVehicleTypeRepository> _vehicleTypeRepositoryMock = new Mock<IVehicleTypeRepository>();

            var vehicleTypeList = new List<Domain.VehicleType>();
            vehicleTypeList.Add(new Domain.VehicleType()
            {
                Id = 1,
                Name = "Car"
            });

            _vehicleTypeRepositoryMock.Setup(_ => _.ListAsync()).ReturnsAsync(vehicleTypeList);

            return _vehicleTypeRepositoryMock;
        }
    }
}
