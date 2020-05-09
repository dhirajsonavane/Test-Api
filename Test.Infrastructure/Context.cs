using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Test.Domain;

namespace Test.Infrastructure
{
    public class Context : DbContext
    {
        public Context() { }
        private DbContextOptions<Context> _options;
        public Context(DbContextOptions<Context> options)
        {
            _options = options;
        }

        public DbSet<Monitoring> VenueType { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = string.Empty;

            try
            {
                var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
                var jsonPath = "appsettings.json";

                if (!string.IsNullOrEmpty(env) && env != "Production")
                {
                    jsonPath = $"appsettings.{env}.json";
                }

                connStr = new ConfigurationBuilder()
                    .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), jsonPath))
                    .Build()
                    .GetConnectionString("DatabaseConnection");
            }
            catch (Exception)
            {
                connStr = string.Empty;
            }


            if (!optionsBuilder.IsConfigured)
            {
                if (!string.IsNullOrEmpty(connStr))
                {
                    optionsBuilder.UseSqlServer(connStr);
                }
                else
                {
                    optionsBuilder.UseInMemoryDatabase("TEST");
                }
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ApplyAdditionalConfiguration(ref modelBuilder);
            PopulateData(ref modelBuilder);
        }

        private void ApplyAdditionalConfiguration(ref ModelBuilder modelBuilder)
        {

        }

        private void PopulateData(ref ModelBuilder modelBuilder)
        {
            var vehicleType = new VehicleType()
            {
                Id = 1,
                Name = "Car"
            };

            modelBuilder.Entity<VehicleType>().HasData(vehicleType);

            _ = modelBuilder.Entity<Monitoring>().HasData(
                new Monitoring { ImageId = 35075, VehicleId = 13403, Time = 0.2, VehicleType = 1, Latitude = -27.5599, Longitude = 153.0813, Speed = 8.470203, Acceleration = 5.503848, X_Coordinate = 536.0326, Y_Coordinate = 537.3757 },
                new Monitoring { ImageId = 35076, VehicleId = 13403, Time = 0.3, VehicleType = 1, Latitude = -27.5599, Longitude = 153.0813, Speed = 9.011817, Acceleration = 5.416137, X_Coordinate = 570.4029, Y_Coordinate = 541.9049 },
                new Monitoring { ImageId = 35077, VehicleId = 13403, Time = 0.4, VehicleType = 1, Latitude = -27.5599, Longitude = 153.0813, Speed = 9.52096, Acceleration = 5.091429, X_Coordinate = 606.1474, Y_Coordinate = 547.1406 },
                new Monitoring { ImageId = 35078, VehicleId = 13403, Time = 0.5, VehicleType = 1, Latitude = -27.5599, Longitude = 153.0813, Speed = 9.982243, Acceleration = 4.61283, X_Coordinate = 643.6301, Y_Coordinate = 553.0342 },
                new Monitoring { ImageId = 35079, VehicleId = 13403, Time = 0.6, VehicleType = 1, Latitude = -27.5599, Longitude = 153.0813, Speed = 10.38602, Acceleration = 4.037742, X_Coordinate = 683.2078, Y_Coordinate = 559.5328 });
        }
    }
}