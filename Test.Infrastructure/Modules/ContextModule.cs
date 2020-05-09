using Autofac;

namespace Test.Infrastructure.Modules
{
    class ContextModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(ctx => new Context()).AsSelf();
        }
    }
}
