using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Routing;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorImageBrowserSettings
    /// </summary>
    public partial class EditorImageBrowserSettingsBuilder

    {
        public EditorImageBrowserSettingsBuilder(EditorImageBrowserSettings container)
        {
            Container = container;
        }

        protected EditorImageBrowserSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here

        public EditorImageBrowserSettingsBuilder Create(string actionName, string controllerName)
        {
            return Create(actionName, controllerName, (object) null);
        }

        public EditorImageBrowserSettingsBuilder Create(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.Create.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Create);
            return this;
        }

        public EditorImageBrowserSettingsBuilder Create(string actionName, string controllerName, object routeValues)
        {
            Container.Create.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Create);
            return this;
        }

        public EditorImageBrowserSettingsBuilder Create(Action<EditorImageBrowserOperationBuilder> configurator)
        {
            configurator(new EditorImageBrowserOperationBuilder(Container.Create, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }

        public EditorImageBrowserSettingsBuilder Destroy(string actionName, string controllerName)
        {
            return Destroy(actionName, controllerName, (object) null);
        }

        public EditorImageBrowserSettingsBuilder Destroy(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.Destroy.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Destroy);
            return this;
        }

        public EditorImageBrowserSettingsBuilder Destroy(string actionName, string controllerName, object routeValues)
        {
            Container.Destroy.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Destroy);
            return this;
        }

        public EditorImageBrowserSettingsBuilder Destroy(Action<EditorImageBrowserOperationBuilder> configurator)
        {
            configurator(new EditorImageBrowserOperationBuilder(Container.Destroy, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }
                
        public EditorImageBrowserSettingsBuilder Image(string actionName, string controllerName)
        {
            return Image(actionName, controllerName, (object) null);
        }

        public EditorImageBrowserSettingsBuilder Image(string url)
        {
            Container.Image.Url = Container.Editor.UrlGenerator.Generate(Container.Editor.ViewContext, url);
            return this;
        }

        public EditorImageBrowserSettingsBuilder Image(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.Image.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Image);
            return this;
        }

        public EditorImageBrowserSettingsBuilder Image(string actionName, string controllerName, object routeValues)
        {
            Container.Image.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Image);
            return this;
        }

        public EditorImageBrowserSettingsBuilder Image(Action<EditorImageBrowserOperationBuilder> configurator)
        {
            configurator(new EditorImageBrowserOperationBuilder(Container.Image, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }

        public EditorImageBrowserSettingsBuilder Read(string actionName, string controllerName)
        {
            return Read(actionName, controllerName, (object) null);
        }

        public EditorImageBrowserSettingsBuilder Read(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.Read.Action(actionName, controllerName, routeValues);

            SetUrl(Container.Read);

            return this;
        }

        public EditorImageBrowserSettingsBuilder Read(string actionName, string controllerName, object routeValues)
        {
            Container.Read.Action(actionName, controllerName, routeValues);

            SetUrl(Container.Read);

            return this;
        }

        public EditorImageBrowserSettingsBuilder Read(Action<EditorImageBrowserOperationBuilder> configurator)
        {
            configurator(new EditorImageBrowserOperationBuilder(Container.Read, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }

        public EditorImageBrowserSettingsBuilder Thumbnail(string actionName, string controllerName)
        {
            return Thumbnail(actionName, controllerName, (object) null);
        }

        public EditorImageBrowserSettingsBuilder Thumbnail(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.Thumbnail.Action(actionName, controllerName, routeValues);

            SetUrl(Container.Thumbnail);

            return this;
        }

        public EditorImageBrowserSettingsBuilder Thumbnail(string actionName, string controllerName, object routeValues)
        {
            Container.Thumbnail.Action(actionName, controllerName, routeValues);

            SetUrl(Container.Thumbnail);

            return this;
        }

        public EditorImageBrowserSettingsBuilder Thumbnail(Action<EditorImageBrowserOperationBuilder> configurator)
        {
            configurator(new EditorImageBrowserOperationBuilder(Container.Thumbnail, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }

        public EditorImageBrowserSettingsBuilder Upload(string actionName, string controllerName)
        {
            return Upload(actionName, controllerName, (object) null);
        }

        public EditorImageBrowserSettingsBuilder Upload(string actionName, string controllerName, RouteValueDictionary routeValues)
        {
            Container.Upload.Action(actionName, controllerName, routeValues);

            SetUrl(Container.Upload);

            return this;
        }

        public EditorImageBrowserSettingsBuilder Upload(string actionName, string controllerName, object routeValues)
        {
            Container.Upload.Action(actionName, controllerName, routeValues);
            SetUrl(Container.Upload);
            return this;
        }

        public EditorImageBrowserSettingsBuilder Upload(Action<EditorImageBrowserOperationBuilder> configurator)
        {
            configurator(new EditorImageBrowserOperationBuilder(Container.Upload, Container.Editor.ViewContext, Container.Editor.UrlGenerator));

            return this;
        }

        private void SetUrl(INavigatable operation)
        {
            operation.Url = operation.GenerateUrl(Container.Editor.ViewContext, Container.Editor.UrlGenerator);
        }
    }
}
