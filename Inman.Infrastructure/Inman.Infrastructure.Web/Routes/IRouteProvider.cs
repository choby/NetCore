using Microsoft.AspNetCore.Routing;

namespace Inman.Infrastructure.Web
{
    public interface IRouteProvider
    {
        void RegisterRoutes(RouteCollection routes);

        int Priority { get; }
    }
}
