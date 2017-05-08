namespace Kendo.Mvc.UI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using Extensions;
    using Kendo.Mvc.Resources;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Routing;
    using Microsoft.Extensions.DependencyInjection;
    using Infrastructure;
    using Microsoft.AspNetCore.Mvc.Routing;
    public static class NavigatableExtensions
    {
        /// <summary>
        /// Sets the action, controller name and route values of <see cref="INavigatable"/> object.
        /// </summary>
        /// <param name="navigatable">The <see cref="INavigatable"/> object.</param>
        /// <param name="routeValues">The route values of the Action method.</param>
        public static void Action(this INavigatable navigatable, RouteValueDictionary routeValues)
        {
            routeValues.ApplyTo(navigatable, SetAction);
        }

        /// <summary>
        /// Sets the action and controller name, along with Route values of <see cref="INavigatable"/> object.
        /// </summary>
        /// <param name="navigatable">The <see cref="INavigatable"/> object.</param>
        /// <param name="actionName">Action name.</param>
        /// <param name="controllerName">Controller name.</param>
        /// <param name="routeValues">Route values as an object</param>
        public static void Action(this INavigatable navigatable, string actionName, string controllerName, object routeValues)
        {
            navigatable.ControllerName = controllerName;
            navigatable.ActionName = actionName;
            navigatable.SetRouteValues(routeValues);
        }

        /// <summary>
        /// Sets the action, controller name and route values of <see cref="INavigatable"/> object.
        /// </summary>
        /// <param name="navigatable">The <see cref="INavigatable"/> object.</param>
        /// <param name="actionName">Action name.</param>
        /// <param name="controllerName">Controller name.</param>
        /// <param name="routeValues">Route values as <see cref="RouteValueDictionary"/></param>
        public static void Action(this INavigatable navigatable, string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            SetAction(navigatable, actionName, controllerName, routeValues);
        }

        /// <summary>
        /// Sets the action and route values of <see cref="INavigatable"/> object.
        /// </summary>
        /// <param name="item">The <see cref="INavigatable"/> object.</param>
        /// <param name="controllerAction">The controller action.</param>
        public static void Action<TController>(this INavigatable item, Expression<Action<TController>> controllerAction) where TController : Controller
        {
            MethodCallExpression call = (MethodCallExpression)controllerAction.Body;

            string controllerName = typeof(TController).Name;

            if (!controllerName.EndsWith("Controller", StringComparison.OrdinalIgnoreCase))
            {
                throw new ArgumentException(Exceptions.ControllerNameMustEndWithController, "controllerAction");
            }

            controllerName = controllerName.Substring(0, controllerName.Length - "Controller".Length);

            if (controllerName.Length == 0)
            {
                throw new ArgumentException(Exceptions.CannotRouteToClassNamedController, "controllerAction");
            }

            if (call.Method.IsDefined(typeof(NonActionAttribute), false))
            {
                throw new ArgumentException(Exceptions.TheSpecifiedMethodIsNotAnActionMethod, "controllerAction");
            }

            string actionName = call.Method.GetCustomAttributes(typeof(ActionNameAttribute), false)
                                           .OfType<ActionNameAttribute>()
                                           .Select(attribute => attribute.Name)
                                           .FirstOrDefault() ?? call.Method.Name;

            item.ControllerName = controllerName;
            item.ActionName = actionName;

            ParameterInfo[] parameters = call.Method.GetParameters();

            for (int i = 0; i < parameters.Length; i++)
            {
                Expression arg = call.Arguments[i];
                object value;
                ConstantExpression ce = arg as ConstantExpression;

                if (ce != null)
                {
                    value = ce.Value;
                }
                else
                {
                    Expression<Func<object>> lambdaExpression = Expression.Lambda<Func<object>>(Expression.Convert(arg, typeof(object)));
                    Func<object> func = lambdaExpression.Compile();
                    value = func();
                }

                item.RouteValues.Add(parameters[i].Name, value);
            }
        }

        /// <summary>
        /// Sets the url property of <see cref="INavigatable"/> object.
        /// </summary>
        /// <param name="navigatable">The <see cref="INavigatable"/> object.</param>
        /// <param name="actionName">The Url.</param>
        public static void Url(this INavigatable navigatable, string value)
        {

            navigatable.Url = value;
        }

        /// <summary>
        /// Sets the route name and route values of <see cref="INavigatable"/> object.
        /// </summary>
        /// <param name="navigatable">The <see cref="INavigatable"/> object.</param>
        /// <param name="routeName">Route name.</param>
        /// <param name="routeValues">Route values as an object.</param>
        public static void Route(this INavigatable navigatable, string routeName, object routeValues)
        {

            navigatable.RouteName = routeName;
            navigatable.SetRouteValues(routeValues);
        }

        /// <summary>
        /// Sets the route name and route values of <see cref="INavigatable"/> object.
        /// </summary>
        /// <param name="navigatable">The <see cref="INavigatable"/> object.</param>
        /// <param name="routeName">Route name.</param>
        /// <param name="routeValues">Route values as <see cref="RouteValueDictionary"/>.</param>
        public static void Route(this INavigatable navigatable, string routeName, RouteValueDictionary routeValues)
        {

            navigatable.RouteName = routeName;
            navigatable.SetRouteValues(routeValues);
        }

        /// <summary>
        /// Generating url depending on the ViewContext and the <see cref="IUrlGenerator"/> generator.
        /// </summary>
        /// <param name="navigatable">The <see cref="INavigatable"/> object.</param>
        /// <param name="viewContext">The <see cref="ViewContext"/> object</param>
        /// <param name="urlGenerator">The <see cref="IUrlGenerator"/> generator.</param>
        public static string GenerateUrl(this INavigatable navigatable, ViewContext viewContext, IUrlGenerator urlGenerator)
        {
            return urlGenerator.Generate(viewContext, navigatable);
        }

        /// <summary>
        /// Determines whether the specified navigatable matches the current request URL.
        /// </summary>
        /// <param name="navigatable">The <see cref="INavigatable"/> object.</param>
        /// <param name="viewContext">The <see cref="ViewContext"/> object.</param>
        /// <param name="urlGenerator">The <see cref="IUrlGenerator"/> generator.</param>
        /// <returns></returns>
        public static bool IsCurrent(this INavigatable navigatable, ViewContext viewContext, IUrlGenerator urlGenerator)
        {
            var request = viewContext.HttpContext.Request;

            var currentUrl = request.Path + request.QueryString;
            var url = urlGenerator.Generate(viewContext, navigatable);
            var currentRoute = GetUrlHelper(viewContext).RouteUrl(viewContext.RouteData.Values);

            return !string.IsNullOrEmpty(url) && (url.IsCaseInsensitiveEqual(currentUrl) || url.IsCaseInsensitiveEqual(currentRoute));
        }

        public static IUrlHelper GetUrlHelper(ActionContext context)
        {
            var factory = context.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>();

            return factory.GetUrlHelper(context);
        }

        /// <summary>
        /// Generating url depending on the ViewContext and the <see cref="IUrlGenerator"/> generator.
        /// </summary>
        /// <param name="navigatable">The <see cref="INavigatable"/> object.</param>
        /// <param name="viewContext">The <see cref="ViewContext"/> object</param>
        /// <param name="urlGenerator">The <see cref="IUrlGenerator"/> generator.</param>
        public static string GenerateUrl(this INavigatable navigatable, ViewContext viewContext, IUrlGenerator urlGenerator, RouteValueDictionary routeValues)
        {
            return urlGenerator.Generate(viewContext, navigatable, routeValues);
        }
              
        /// <summary>
        /// Determines whether this instance has value.
        /// </summary>
        /// <returns>true if either ActionName and ControllerName, RouteName or Url are set; false otherwise</returns>
        public static bool HasValue(this INavigatable navigatable)
        {
            return  (navigatable.ActionName.HasValue() && navigatable.ControllerName.HasValue()) ||
                    navigatable.RouteName.HasValue() ||
                    navigatable.Url.HasValue();
        }

        private static void SetAction(INavigatable navigatable, string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            navigatable.ActionName = actionName;
            navigatable.ControllerName = controllerName;
            navigatable.SetRouteValues(routeValues);
        }

        private static void SetRouteValues(this INavigatable navigatable, object values)
        {
            if (values != null)
            {
                navigatable.RouteValues.Clear();
                navigatable.RouteValues.Merge(values);
            }
        }

        private static void SetRouteValues(this INavigatable navigatable, IDictionary<string, object> values)
        {
            if (values != null)
            {
                navigatable.RouteValues.Clear();
                navigatable.RouteValues.Merge(values);
            }
        }

        //public static bool IsAccessible(this INavigatable item, INavigationItemAuthorization authorization, ViewContext viewContext)
        //{
        //    return authorization.IsAccessibleToUser(viewContext.HttpContext, item);
        //}

        //public static bool IsAccessible<T>(this IEnumerable<T> items, INavigationItemAuthorization authorization, ViewContext viewContext)
        //{
        //    return items.Any(item => authorization.IsAccessibleToUser(viewContext.HttpContext, (INavigatable)item));
        //}
    }
}