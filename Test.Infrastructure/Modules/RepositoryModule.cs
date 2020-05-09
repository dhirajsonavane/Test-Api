using Autofac;
using Test.Infrastructure.Repository;
using Module = Autofac.Module;

namespace Test.Infrastructure.Modules
{
    class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(ctx => new MonitoringRepository(ctx.Resolve<Context>())).As<IMonitoringRepository>();
            builder.Register(ctx => new VehicleTypeRepository(ctx.Resolve<Context>())).As<IVehicleTypeRepository>();
        }
    }
}
