using AutoMapper;
using Moq;
using Test.Core.ObjectMap;
using Test.Core.Services;
using Xunit;

namespace Test.Test
{
    public class MonitoringServiceTest
    {
        private readonly IMapper _mapper;
        public MonitoringServiceTest()
        {
            var cfg = new MapperConfiguration(cfg => cfg.AddProfile(new ObjectMapProfiles()));
            _mapper = cfg.CreateMapper();
        }

        [Fact]
        public async void ListAsync_Success()
        {
            // Arrange
            var _monitoringRepositoryMock = MonitoringTestBase.ListAsync();
            var _vehicleTypeRepositoryMock = VehicleTypeTestBase.ListAsync();
            var _service = new MonitoringService(_mapper, _monitoringRepositoryMock.Object, _vehicleTypeRepositoryMock.Object);

            // Act
            var result = await _service.ListAsync();

            //Assert
            _monitoringRepositoryMock.Verify(_ => _.ListAsync(), Times.Once);
            Assert.NotNull(result);
        }
    }
}
