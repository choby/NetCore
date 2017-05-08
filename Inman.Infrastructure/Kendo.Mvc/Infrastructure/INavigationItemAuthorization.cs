namespace Kendo.Mvc.Infrastructure
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Routing;

    public interface INavigationItemAuthorization
    {
        bool IsAccessibleToUser(HttpContext requestContext, INavigatable navigationItem);
    }
}