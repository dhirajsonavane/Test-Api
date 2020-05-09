using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace Test.Infrastructure
{
    public class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var jsonPath = "appsettings.json";

            if (!string.IsNullOrEmpty(env) && env != "Production")
            {
                jsonPath = $"appsettings.{env}.json";
            }

            var context = new Context(new DbContextOptionsBuilder<Context>().UseSqlServer(
               new ConfigurationBuilder()
                   .AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), jsonPath))
                   .Build()
                   .GetConnectionString("DatabaseConnection")
               ).Options);

            return context;
        }
    }
}
