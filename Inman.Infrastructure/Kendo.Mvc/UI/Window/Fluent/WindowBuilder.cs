using System;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Kendo.Mvc.UI.Fluent
{
	/// <summary>
	/// Defines the fluent API for configuring the Kendo UI Window
	/// </summary>
	public partial class WindowBuilder : WidgetBuilderBase<Window, WindowBuilder>
	{
		public WindowBuilder(Window component) : base(component)
		{
		}

		/// <summary>
		/// Configures the window buttons.
		/// </summary>
		/// <param name="actionsBuilderAction">The buttons configuration action.</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .Actions(actions =>
		///                 actions.Close()
		///             )
		/// %&gt;
		/// </code>
		/// </example>
		public WindowBuilder Actions(Action<WindowActionsBuilder> actionsBuilderAction)
		{
			Component.Actions.Container.Clear();

			actionsBuilderAction(new WindowActionsBuilder(Component.Actions));

			return this;
		}

		/// <summary>
		/// Configures the animation effects of the panelbar.
		/// </summary>
		/// <param name="animationAction">The action that configures the animation.</param>
		/// <example>
		/// <code lang="CS">
		/// &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .Animation(animation => animation.Expand)
		/// </code>
		/// </example>
		public WindowBuilder Animation(Action<PopupAnimationBuilder> animationAction)
		{
			animationAction(new PopupAnimationBuilder(Component.Animation));

			return this;
		}

		/// <summary>
		/// Configures the animation effects of the window.
		/// </summary>
		/// <param name="enable">Whether the component animation is enabled.</param>
		/// <example>
		/// <code lang="CS">
		/// &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .Animation(false)
		/// </code>
		/// </example>
		public WindowBuilder Animation(bool enable)
		{
			Component.Animation.Enabled = enable;

			return this;

		}

		/// <summary>
		/// Defines a selector for the element to which the Window will be appended. By default this is the page body.
		/// </summary>
		/// <param name="selector">A selector of the Window container</param>
		public WindowBuilder AppendTo(string selector)
		{
			Component.AppendTo = selector;

			return this;

		}

		/// <summary>
		/// Sets the HTML content which the window should display.
		/// </summary>
		/// <param name="value">The action which renders the content.</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;% Html.Kendo().Window()
		///            .Name("Window")
		///            .Content(() => 
		///            { 
		///               %&gt;
		///                     &lt;strong&gt;Window content&lt;/strong&gt;
		///               &lt;% 
		///            })
		/// %&gt;
		/// </code>
		/// </example>
		public WindowBuilder Content(Action value)
		{
			Component.ContentAction = value;
			return this;
		}

		/// <summary>
		/// Sets the HTML content which the window should display
		/// </summary>
		/// <param name="value">The Razor inline template</param>
		/// <example>
		/// <code lang="CS">
		///  @(Html.Kendo().Window()
		///            .Name("Window")
		///            .Content(@&lt;strong&gt; Hello World!&lt;/strong&gt;))
		/// </code>        
		/// </example>
		/// <returns></returns>
		public WindowBuilder Content(Func<object, object> value)
		{
			Component.Content = value;

			return this;
		}

		/// <summary>
		/// Sets the HTML content which the item should display as a string.
		/// </summary>
		/// <param name="value">The action which renders the content.</param>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .Content("&lt;strong&gt; First Item Content&lt;/strong&gt;")
		/// %&gt;
		/// </code>        
		public WindowBuilder Content(string value)
		{
			Component.Html = value;

			return this;
		}

		/// <summary>
		/// Enables (true) or disables (false) the ability for users to move/drag the widget.
		/// </summary>
		/// <param name="value">The value for Draggable</param>
		public WindowBuilder Draggable()
		{
			Draggable(true);
			return this;
		}


		/// <summary>
		/// Sets the Url, which will be requested to return the content. 
		/// </summary>
		/// <param name="routeValues">The route values of the Action method.</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().Window()
		///         .Name("Window")
		///         .LoadContentFrom(MVC.Home.Index().GetRouteValueDictionary());
		/// %&gt;
		/// </code>
		/// </example>
		public WindowBuilder LoadContentFrom(RouteValueDictionary routeValues)
		{
			return routeValues.ApplyTo<WindowBuilder>(LoadContentFrom);
		}

		/// <summary>
		/// Sets the Url, which will be requested to return the content. 
		/// </summary>
		/// <param name="actionName">The action name.</param>
		/// <param name="controllerName">The controller name.</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .LoadContentFrom("AjaxView_OpenSource", "Window")
		/// %&gt;
		/// </code>
		/// </example>
		public WindowBuilder LoadContentFrom(string actionName, string controllerName)
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
		///  &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .LoadContentFrom("AjaxView_OpenSource", "Window", new { id = 10})
		/// %&gt;
		/// </code>
		/// </example>
		public WindowBuilder LoadContentFrom(string actionName, string controllerName, object routeValues)
		{
			return LoadContentFrom(actionName, controllerName, new RouteValueDictionary(routeValues));
		}

		public WindowBuilder LoadContentFrom(string actionName, string controllerName, RouteValueDictionary routeValues)
		{
            var factory = Container.ViewContext.HttpContext.RequestServices.GetRequiredService<IUrlHelperFactory>();

            var urlHelper = factory.GetUrlHelper(Container.ViewContext);

			return LoadContentFrom(urlHelper.Action(actionName, controllerName, routeValues));
		}

		/// <summary>
		/// Sets the Url, which will be requested to return the content.
		/// </summary>
		/// <param name="value">The url.</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .LoadContentFrom(Url.Action("AjaxView_OpenSource", "Window"))
		/// %&gt;
		/// </code>
		/// </example>
		public WindowBuilder LoadContentFrom(string value)
		{
			Component.ContentUrl = value;

			return this;
		}

		/// <summary>
		/// Enables windows resizing.
		/// </summary>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .Resizable()
		/// %&gt;
		/// </code>
		/// </example>
		public WindowBuilder Resizable()
		{
			Component.ResizingSettings.Enabled = true;

			return this;
		}

		/// <summary>
		/// Configures the resizing ability of the window.
		/// </summary>
		/// <param name="resizingSettingsAction">Resizing settings action.</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().Window()
		///             .Name("Window")
		///             .Resizable(settings =>
		///                 settings.Enabled(true).MaxHeight(500).MaxWidth(500)
		///             )
		/// %&gt;
		/// </code>
		/// </example>
		public WindowBuilder Resizable(Action<WindowResizingSettingsBuilder> resizingSettingsAction)
		{
			Component.ResizingSettings.Enabled = true;

			resizingSettingsAction(new WindowResizingSettingsBuilder(Component.ResizingSettings));

			return this;
		}
	}
}

