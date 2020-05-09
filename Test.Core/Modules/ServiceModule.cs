using Autofac;
using AutoMapper;
using Test.Core.Services;
using Test.Infrastructure.Repository;

namespace Test.Core.Modules
{
    class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(ctx => new MonitoringService(ctx.Resolve<IMapper>(), ctx.Resolve<IMonitoringRepository>(), ctx.Resolve<IVehicleTypeRepository>())).As<IMonitoringService>();
        }
    }
}
