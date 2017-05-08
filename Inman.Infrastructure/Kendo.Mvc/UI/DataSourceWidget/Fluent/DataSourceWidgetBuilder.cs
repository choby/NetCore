using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Encodings.Web;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI DataSource
    /// </summary>
    ///
    public class DataSourceWidgetBuilder<T> : HelperResult
        where T : class
    {
        /// <summary>
        /// Gets the view component.
        /// </summary>
        /// <value>The component.</value>

        public DataSourceWidgetBuilder(DataSourceWidget<T> component) : base(async (writer) => await Task.Yield())
        {
            Component = component;
        }

        protected internal DataSourceWidget<T> Component
        {
            get;
            set;
        }

        /// <summary>
        /// Sets the name of the component.
        /// </summary>
        /// <param name="componentName">The name.</param>
        /// <returns></returns>
        public virtual DataSourceWidgetBuilder<T> Name(string componentName)
        {
            Component.Name = componentName;

            return this;
        }

        public override void WriteTo(TextWriter writer, HtmlEncoder encoder)
        {
            Component.Render();
        }

        protected readonly IUrlGenerator urlGenerator;
        protected readonly ViewContext viewContext;

        /// <summary>
        /// Use it to configure Ajax binding.
        /// </summary>
        public DataSourceWidgetBuilder<T> Ajax(Action<AjaxDataSourceBuilder<T>> configurator)
        {
            Component.DataSource.Type = DataSourceType.Ajax;
            configurator(new AjaxDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        /// <summary>
        /// Use it to configure WebApi binding.
        /// </summary>
        public DataSourceWidgetBuilder<T> WebApi(Action<WebApiDataSourceBuilder<T>> configurator)
        {
            Component.DataSource.Type = DataSourceType.WebApi;
            configurator(new WebApiDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        /// <summary>
        /// Use it to configure Custom binding.
        /// </summary>
        public DataSourceWidgetBuilder<T> Custom(Action<CustomDataSourceBuilder<T>> configurator)
        {
            Component.DataSource.Type = DataSourceType.Custom;
            configurator(new CustomDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        /// <summary>
        /// Use it to configure SignalR binding.
        /// </summary>
        public DataSourceWidgetBuilder<T> SignalR(Action<SignalRDataSourceBuilder<T>> configurator)
        {
            Component.DataSource.Type = DataSourceType.Custom;
            configurator(new SignalRDataSourceBuilder<T>(Component.DataSource));
            return this;
        }

        public DataSourceWidgetBuilder<T> Gantt(Action<GanttDataSourceBuilder<T>> configurator)
        {
            Component.ClassName = "GanttDataSource";
            Component.DataSource.Schema.Model = new GanttTaskModelDescriptor(typeof(T), Component.ModelMetadataProvider);
            configurator(new GanttDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }


        public DataSourceWidgetBuilder<T> GanttDependency(Action<GanttDependenciesDataSourceBuilder<T>> configurator)
        {
            Component.ClassName = "GanttDependencyDataSource";
            Component.DataSource.Schema.Model = new GanttDependencyModelDescriptor(typeof(T), Component.ModelMetadataProvider);
            configurator(new GanttDependenciesDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        public DataSourceWidgetBuilder<T> Pivot(Action<PivotDataSourceBuilder<T>> configurator)
        {
            Component.PivotDataSource = new PivotDataSource(Component.ModelMetadataProvider);
            Component.ClassName = "PivotDataSource";
            configurator(new PivotDataSourceBuilder<T>(Component.PivotDataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        public DataSourceWidgetBuilder<T> Hierarchical(Action<HierarchicalDataSourceBuilder<T>> configurator)
        {
            Component.ClassName = "HierarchicalDataSource";
            Component.DataSource.Schema.Model = new TreeListModelDescriptor(typeof(object), Component.ModelMetadataProvider);
            configurator(new HierarchicalDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        public DataSourceWidgetBuilder<T> TreeList(Action<TreeListAjaxDataSourceBuilder<T>> configurator)
        {
            Component.ClassName = "TreeListDataSource";
            Component.DataSource.Schema.Model = new TreeListModelDescriptor(typeof(object), Component.ModelMetadataProvider);
            configurator(new TreeListAjaxDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));
            return this;
        }

        /// <summary>
        /// Renders the component in place.
        /// </summary>
        public virtual void Render()
        {
            Component.Render();
        }
    }
}

