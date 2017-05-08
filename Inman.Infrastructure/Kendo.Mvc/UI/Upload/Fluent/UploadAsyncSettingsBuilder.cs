using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace Kendo.Mvc.UI.Fluent
{
	/// <summary>
	/// Defines the fluent API for configuring UploadAsyncSettings
	/// </summary>
	public partial class UploadAsyncSettingsBuilder

	{
		public UploadAsyncSettingsBuilder(UploadAsyncSettings container)
		{
			Container = container;
		}

		protected UploadAsyncSettings Container
		{
			get;
			private set;
		}

		public UploadAsyncSettingsBuilder Save(string actionName, string controllerName, RouteValueDictionary routeValues)
		{
			Container.Save.Action(actionName, controllerName, routeValues);

			return this;
		}

		public UploadAsyncSettingsBuilder Save(string actionName, string controllerName, object routeValues)
		{
			Container.Save.Action(actionName, controllerName, routeValues);

			return this;
		}

		public UploadAsyncSettingsBuilder Save(string actionName, string controllerName)
		{
			return Save(actionName, controllerName, (object)null);
		}

		public UploadAsyncSettingsBuilder Save(string routeName)
		{
			return Save(routeName, (object)null);
		}

		public UploadAsyncSettingsBuilder Save(RouteValueDictionary routeValues)
		{
			Container.Save.Action(routeValues);

			return this;
		}

		public UploadAsyncSettingsBuilder Save(string routeName, RouteValueDictionary routeValues)
		{
			Container.Save.Route(routeName, routeValues);

			return this;
		}

		public UploadAsyncSettingsBuilder Save(string routeName, object routeValues)
		{
			Container.Save.Route(routeName, routeValues);

			return this;
		}

		public UploadAsyncSettingsBuilder Save<TController>(Expression<Action<TController>> controllerAction)
			where TController : Controller
		{
			Container.Save.Action(controllerAction);

			return this;
		}

		public UploadAsyncSettingsBuilder Remove(string actionName, string controllerName, RouteValueDictionary routeValues)
		{
			Container.Remove.Action(actionName, controllerName, routeValues);

			return this;
		}

		public UploadAsyncSettingsBuilder Remove(string actionName, string controllerName, object routeValues)
		{
			Container.Remove.Action(actionName, controllerName, routeValues);

			return this;
		}

		public UploadAsyncSettingsBuilder Remove(string actionName, string controllerName)
		{
			return Remove(actionName, controllerName, (object)null);
		}

		public UploadAsyncSettingsBuilder Remove(string routeName)
		{
			return Remove(routeName, (object)null);
		}

		public UploadAsyncSettingsBuilder Remove(RouteValueDictionary routeValues)
		{
			Container.Remove.Action(routeValues);

			return this;
		}

		public UploadAsyncSettingsBuilder Remove(string routeName, RouteValueDictionary routeValues)
		{
			Container.Remove.Route(routeName, routeValues);

			return this;
		}

		public UploadAsyncSettingsBuilder Remove(string routeName, object routeValues)
		{
			Container.Remove.Route(routeName, routeValues);

			return this;
		}

		public UploadAsyncSettingsBuilder Remove<TController>(Expression<Action<TController>> controllerAction)
			where TController : Controller
		{
			Container.Remove.Action(controllerAction);

			return this;
		}
	}
}
