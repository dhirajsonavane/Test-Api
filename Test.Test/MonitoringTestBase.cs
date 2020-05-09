using Moq;
using System.Collections.Generic;
using Test.Infrastructure.Repository;

namespace Test.Test
{
    public static class MonitoringTestBase
    {
        public static Mock<IMonitoringRepository> ListAsync()
        {
            Mock<IMonitoringRepository> _monitoringRepositoryMock = new Mock<IMonitoringRepository>();

            var monitoringList = new List<Domain.Monitoring>();
            monitoringList.Add(new Domain.Monitoring()
            {
                ImageId = 35075,
                VehicleId = 13403,
                Time = 0.2,
                VehicleType = 1,
                Latitude = -27.5599,
                Longitude = 153.0813,
                Speed = 8.470203,
                Acceleration = 5.503848,
                X_Coordinate = 536.0326,
                Y_Coordinate = 537.3757
            });
            monitoringList.Add(new Domain.Monitoring()
            {
                ImageId = 35076,
                VehicleId = 13403,
                Time = 0.3,
                VehicleType = 1,
                Latitude = -27.5599,
                Longitude = 153.0813,
                Speed = 9.011817,
                Acceleration = 5.416137,
                X_Coordinate = 570.4029,
                Y_Coordinate = 541.9049
            });
            monitoringList.Add(new Domain.Monitoring()
            {
                ImageId = 35077,
                VehicleId = 13403,
                Time = 0.4,
                VehicleType = 1,
                Latitude = -27.5599,
                Longitude = 153.0813,
                Speed = 9.52096,
                Acceleration = 5.091429,
                X_Coordinate = 606.1474,
                Y_Coordinate = 547.1406
            });
            monitoringList.Add(new Domain.Monitoring()
            {
                ImageId = 35078,
                VehicleId = 13403,
                Time = 0.5,
                VehicleType = 1,
                Latitude = -27.5599,
                Longitude = 153.0813,
                Speed = 9.982243,
                Acceleration = 4.61283,
                X_Coordinate = 643.6301,
                Y_Coordinate = 553.0342
            });
            monitoringList.Add(new Domain.Monitoring()
            {
                ImageId = 35079,
                VehicleId = 13403,
                Time = 0.6,
                VehicleType = 1,
                Latitude = -27.5599,
                Longitude = 153.0813,
                Speed = 10.38602,
                Acceleration = 4.037742,
                X_Coordinate = 683.2078,
                Y_Coordinate = 559.5328
            });

            _monitoringRepositoryMock.Setup(_ => _.ListAsync()).ReturnsAsync(monitoringList);

            return _monitoringRepositoryMock;
        }
    }
}
