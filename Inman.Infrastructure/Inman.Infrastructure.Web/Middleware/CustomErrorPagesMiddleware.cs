using Inman.Infrastructure.Common.IOC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inman.Infrastructure.Web.Middleware
{
    public class CustomErrorPagesMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        private static readonly IDictionary<int, string> _errorPages = new Dictionary<int, string>();

        public CustomErrorPagesMiddleware(IHostingEnvironment env, ILoggerFactory loggerFactory, RequestDelegate next)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<CustomErrorPagesMiddleware>();
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(0, ex, "An unhandled exception has occurred while executing the request");

                if (context.Response.HasStarted)
                {
                    _logger.LogWarning("The response has already started, the error page middleware will not be executed.");
                    throw;
                }
                try
                {
                    context.Response.Clear();
                    context.Response.StatusCode = 500;
                    return;
                }
                catch (Exception ex2)
                {
                    _logger.LogError(0, ex2, "An exception was thrown attempting to display the error page.");
                }
                throw;
            }
            finally
            {
                var statusCode = context.Response.StatusCode;
                if (statusCode == 404 || statusCode == 500)
                {
                    await ErrorPage.ResponseAsync(context.Response, statusCode);
                }
            }
        }

    }

    public static class ErrorPage
    {
        public static async Task ResponseAsync(HttpResponse response, int statusCode)
        {
            if (statusCode == 404)
            {
                await response.WriteAsync(Page404);
            }
            else if (statusCode == 500)
            {
                await response.WriteAsync(Page500);
            }
        }

        private static string Page404 => @"html...";

        private static string Page500 => @"html...";
    }

    public static class CustomErrorPagesExtensions
    {
        public static IApplicationBuilder UseCustomErrorPages(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            return app.UseMiddleware<CustomErrorPagesMiddleware>();
        }
    }
}
