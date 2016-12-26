using Autofac;

namespace Inman.Infrastructure.Common.IOC
{
    public interface IDependencyRegistrar
    {
        void Register(ContainerBuilder builder, ITypeFinder typeFinder);

        int Order { get; }
    }
}
