namespace Kendo.Mvc.UI.Fluent
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Defines the fluent interface for configuring the Gantt <see cref="DataSource"/>.
    /// </summary>
    public class GanttDataSourceBuilder<TModel> : FilterableAjaxDataSourceBuilder<TModel, GanttDataSourceBuilder<TModel>>
         where TModel : class
    {
        public GanttDataSourceBuilder(DataSource dataSource, ViewContext viewContext, IUrlGenerator urlGenerator)
            : base(dataSource, viewContext, urlGenerator)
        {
        }

        /// <summary>
        /// Configures Model properties
        /// </summary>
        public GanttDataSourceBuilder<TModel> Model(Action<GanttTaskModelDescriptorFactory<TModel>> configurator)
        {
            configurator(new GanttTaskModelDescriptorFactory<TModel>((GanttTaskModelDescriptor)dataSource.Schema.Model));

            return this;
        }
    }
}
