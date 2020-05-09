using Autofac;
using AutoMapper;
using Test.Core.ObjectMap;

namespace Test.Core.Modules
{
    public class ObjectMapModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(ctx => new MapperConfiguration(cfg => cfg.AddProfile(new ObjectMapProfiles()))).AsSelf().SingleInstance();

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper(ctx.Resolve)).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}
