using Autofac;
using Inman.Infrastructure.Common;

namespace Inman.Infrastructure.IOC
{
    public interface IDependencyRegistrar
    {
        void Register(ContainerBuilder builder, ITypeFinder typeFinder);

        int Order { get; }
    }
}
