using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SplitterPane
    /// </summary>
    public partial class SplitterPaneBuilder
        
    {
        private readonly Regex sizeValueRegex = new Regex(@"^\d+(px|%)$", RegexOptions.IgnoreCase);

        public SplitterPaneBuilder(SplitterPane container)
        {
            Container = container;
        }

        protected SplitterPane Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the minimum pane size.
        /// </summary>
        /// <param name="size">The desired minimum size. Only sizes in pixels and percentages are allowed.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Splitter()
        ///             .Name("Splitter")
        ///             .Panes(panes =>
        ///             {
        ///                 panes.Add().MinSize("220px");
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public SplitterPaneBuilder MinSize(string size)
        {

            if (!sizeValueRegex.IsMatch(size))
            {
                throw new ArgumentException("MinSize should be in pixels or percentages", "size");
            }

            Container.MinSize = size;

            return this;
        }

        /// <summary>
        /// Sets the maximum pane size.
        /// </summary>
        /// <param name="size">The desired maximum size. Only sizes in pixels and percentages are allowed.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Splitter()
        ///             .Name("Splitter")
        ///             .Panes(panes =>
        ///             {
        ///                 panes.Add().MaxSize("220px");
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public SplitterPaneBuilder MaxSize(string size)
        {

            if (!sizeValueRegex.IsMatch(size))
            {
                throw new ArgumentException("MaxSize should be in pixels or percentages", "size");
            }

            Container.MaxSize = size;

            return this;
        }

        /// <summary>
        /// Sets the HTML attributes applied to the outer HTML element rendered for the item
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Splitter()
        ///             .Name("Splitter")
        ///             .Panes(panes =>
        ///             {
        ///                 panes.Add().HtmlAttributes(new { style = "background: red" });
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public SplitterPaneBuilder HtmlAttributes(object attributes)
        {
            return HtmlAttributes(attributes.ToDictionary());
        }

        /// <summary>
        /// Sets the HTML attributes applied to the outer HTML element rendered for the item
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        public SplitterPaneBuilder HtmlAttributes(IDictionary<string, object> attributes)
        {

            Container.HtmlAttributes.Clear();
            Container.HtmlAttributes.Merge(attributes);

            return this;
        }

        /// <summary>
        /// Sets the HTML content of the pane.
        /// </summary>
        /// <param name="content">The action which renders the HTML content.</param>
        /// <code lang="CS">
        ///  &lt;%  Html.Kendo().Splitter()
        ///             .Name("Splitter")
        ///             .Panes(panes =>
        ///             {
        ///                 panes.Add()
        ///                     .Content(() =&gt; { &gt;%
        ///                         &lt;p&gt;Content&lt;/p&gt;
        ///                     %&lt;});
        ///             })
        ///             .Render();
        /// %&gt;
        /// </code>        
        public SplitterPaneBuilder Content(Action content)
        {

            Container.TemplateAction = content;

            return this;
        }

        /// <summary>
        /// Sets the HTML content of the pane.
        /// </summary>
        /// <param name="content">The Razor template for the HTML content.</param>
        /// <code lang="CS">
        ///  @(Html.Kendo().Splitter()
        ///        .Name("Splitter")
        ///        .Panes(panes =>
        ///        {
        ///            panes.Add()
        ///                 .Content(@&lt;p&gt;Content&lt;/p&gt;);
        ///        })
        ///        .Render();)
        /// </code>        
        public SplitterPaneBuilder Content(Func<object, object> content)
        {

            Container.Template = content;

            return this;
        }

        /// <summary>
        /// Sets the HTML content of the pane.
        /// </summary>
        /// <param name="content">The HTML content.</param>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Splitter()
        ///          .Name("Splitter")
        ///          .Panes(panes =>
        ///          {
        ///              panes.Add()
        ///                   .Content("&lt;p&gt;Content&lt;/p&gt;");
        ///          })
        /// %&gt;
        /// </code>        
        public SplitterPaneBuilder Content(string content)
        {

            Container.Html = content;

            return this;
        }

        /// <summary>
        /// Sets the Url which will be requested to return the pane content. 
        /// </summary>
        /// <param name="routeValues">The route values of the Action method.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Splitter()
        ///          .Name("Splitter")
        ///          .Panes(panes => {
        ///               panes.Add()
        ///                     .LoadContentFrom(MVC.Home.Index().GetRouteValueDictionary());
        ///          })
        /// %&gt;
        /// </code>
        /// </example>
        public SplitterPaneBuilder LoadContentFrom(RouteValueDictionary routeValues)
        {
            return routeValues.ApplyTo<SplitterPaneBuilder>(LoadContentFrom);
        }

        /// <summary>
        /// Sets the Url, which will be requested to return the pane content. 
        /// </summary>
        /// <param name="actionName">The action name.</param>
        /// <param name="controllerName">The controller name.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Splitter()
        ///          .Name("Splitter")
        ///          .Panes(panes => {
        ///               panes.Add()
        ///                    .LoadContentFrom("AjaxView_OpenSource", "Splitter");
        ///          })
        /// %&gt;
        /// </code>
        /// </example>
        public SplitterPaneBuilder LoadContentFrom(string actionName, string controllerName)
        {
            return LoadContentFrom(actionName, controllerName, (object)null);
        }

        /// <summary>
        /// Sets the Url, which will be requested to return the content.
        /// </summary>
        /// <param name="actionName">The action name.</param>
        /// <param name="controllerName">The controller name.</param>
        /// <param name="routeValues">Route values.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Splitter()
        ///          .Name("Splitter")
        ///          .Panes(panes => {
        ///               panes.Add()
        ///                    .LoadContentFrom("AjaxView_OpenSource", "Splitter", new { id = 10 });
        ///          })
        /// %&gt;
        /// </code>
        /// </example>
        public SplitterPaneBuilder LoadContentFrom(string actionName, string controllerName, object routeValues)
        {
            return LoadContentFrom(actionName, controllerName, new RouteValueDictionary(routeValues));
        }

        public SplitterPaneBuilder LoadContentFrom(string actionName, string controllerName, RouteValueDictionary routeValues)
        {            
            var urlHelper = GetUrlHelper(Container.Splitter.ViewContext);

            return LoadContentFrom(urlHelper.Action(actionName, controllerName, routeValues));
        }

        /// <summary>
        /// Sets the Url, which will be requested to return the pane content.
        /// </summary>
        /// <param name="value">The url.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Splitter()
        ///          .Name("Splitter")
        ///          .Panes(panes => {
        ///               panes.Add()
        ///                    .LoadContentFrom(Url.Action("AjaxView_OpenSource", "Splitter"));
        ///          })
        /// %&gt;
        /// </code>
        /// </example>
        public SplitterPaneBuilder LoadContentFrom(string value)
        {
            Container.ContentUrl = value;

            return this;
        }

        private static IUrlHelper GetUrlHelper(ViewContext context)
        {
            var factory = context.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>();

            return factory.GetUrlHelper(context);
        }

    }
}
