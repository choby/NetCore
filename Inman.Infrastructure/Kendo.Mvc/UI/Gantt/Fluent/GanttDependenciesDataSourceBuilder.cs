namespace Kendo.Mvc.UI.Fluent
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Defines the fluent interface for configuring the Gantt dependencies <see cref="DataSource"/>.
    /// </summary>
    public class GanttDependenciesDataSourceBuilder<TModel> : FilterableAjaxDataSourceBuilder<TModel, GanttDependenciesDataSourceBuilder<TModel>>
         where TModel : class
    {
        public GanttDependenciesDataSourceBuilder(DataSource dataSource, ViewContext viewContext, IUrlGenerator urlGenerator)
            : base(dataSource, viewContext, urlGenerator)
        {
        }

        /// <summary>
        /// Configures Model properties
        /// </summary>
        public GanttDependenciesDataSourceBuilder<TModel> Model(Action<GanttDependencyModelDescriptorFactory<TModel>> configurator)
        {
            configurator(new GanttDependencyModelDescriptorFactory<TModel>((GanttDependencyModelDescriptor)dataSource.Schema.Model));

            return this;
        }
    }
}
