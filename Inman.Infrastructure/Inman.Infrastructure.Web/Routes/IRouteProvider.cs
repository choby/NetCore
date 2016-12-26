using System.Web.Routing;

namespace Inman.Infrastructure.Web
{
    public interface IRouteProvider
    {
        void RegisterRoutes(RouteCollection routes);

        int Priority { get; }
    }
}
