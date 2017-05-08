using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Routing;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserSettings
    /// </summary>
    public partial class EditorFileBrowserSettingsBuilder

    {
        public EditorFileBrowserSettingsBuilder(EditorFileBrowserSettings container)
        {
            Container = container;
        }

        protected EditorFileBrowserSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here

        public EditorFileBrowserSettingsBuilder Create(string actionName, string controllerName)
        {
            return Create(actionName, controllerName, (object) null);
        }

        public EditorFileBrowserSettingsBuilder Create(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.Create.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Create);
            return this;
        }

        public EditorFileBrowserSettingsBuilder Create(string actionName, string controllerName, object routeValues)
        {
            Container.Create.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Create);
            return this;
        }

        public EditorFileBrowserSettingsBuilder Create(Action<EditorFileBrowserOperationBuilder> configurator)
        {
            configurator(new EditorFileBrowserOperationBuilder(Container.Create, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }

        public EditorFileBrowserSettingsBuilder Destroy(string actionName, string controllerName)
        {
            return Destroy(actionName, controllerName, (object) null);
        }

        public EditorFileBrowserSettingsBuilder Destroy(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.Destroy.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Destroy);
            return this;
        }

        public EditorFileBrowserSettingsBuilder Destroy(string actionName, string controllerName, object routeValues)
        {
            Container.Destroy.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Destroy);
            return this;
        }

        public EditorFileBrowserSettingsBuilder Destroy(Action<EditorFileBrowserOperationBuilder> configurator)
        {
            configurator(new EditorFileBrowserOperationBuilder(Container.Destroy, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }

        public EditorFileBrowserSettingsBuilder File(string actionName, string controllerName)
        {
            return File(actionName, controllerName, (object) null);
        }

        public EditorFileBrowserSettingsBuilder File(string url)
        {
            Container.File.Url = Container.Editor.UrlGenerator.Generate(Container.Editor.ViewContext, url);
            return this;
        }

        public EditorFileBrowserSettingsBuilder File(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.File.Action(actionName, controllerName, routeValues);
            SetUrl(Container.File);
            return this;
        }

        public EditorFileBrowserSettingsBuilder File(string actionName, string controllerName, object routeValues)
        {
            Container.File.Action(actionName, controllerName, routeValues);
            SetUrl(Container.File);
            return this;
        }

        public EditorFileBrowserSettingsBuilder File(Action<EditorFileBrowserOperationBuilder> configurator)
        {
            configurator(new EditorFileBrowserOperationBuilder(Container.File, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }

        public EditorFileBrowserSettingsBuilder Read(string actionName, string controllerName)
        {
            return Read(actionName, controllerName, (object) null);
        }

        public EditorFileBrowserSettingsBuilder Read(string actionName, string controllerName, object routeValues)
        {
            Container.Read.Action(actionName, controllerName, routeValues);

            SetUrl(Container.Read);

            return this;
        }

        public EditorFileBrowserSettingsBuilder Read(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.Read.Action(actionName, controllerName, routeValues);

            SetUrl(Container.Read);

            return this;
        }

        public EditorFileBrowserSettingsBuilder Read(Action<EditorFileBrowserOperationBuilder> configurator)
        {
            configurator(new EditorFileBrowserOperationBuilder(Container.Read, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }
        
        public EditorFileBrowserSettingsBuilder Upload(string actionName, string controllerName)
        {
            return Upload(actionName, controllerName, (object) null);
        }

        public EditorFileBrowserSettingsBuilder Upload(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.Upload.Action(actionName, controllerName, routeValues);

            SetUrl(Container.Upload);

            return this;
        }

        public EditorFileBrowserSettingsBuilder Upload(string actionName, string controllerName, object routeValues)
        {
            Container.Upload.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Upload);
            return this;
        }

        public EditorFileBrowserSettingsBuilder Upload(Action<EditorFileBrowserOperationBuilder> configurator)
        {
            configurator(new EditorFileBrowserOperationBuilder(Container.Upload, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }

        private void SetUrl(INavigatable operation)
        {
            operation.Url = operation.GenerateUrl(Container.Editor.ViewContext, Container.Editor.UrlGenerator);
        }
    }
}
