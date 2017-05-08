using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttAssignmentsSettings
    /// </summary>
    public class GanttAssignmentsSettingsBuilder<TAssingmentModel>
        where TAssingmentModel : class
    {
        private readonly ViewContext viewContext;
        private readonly IUrlGenerator urlGenerator;

        public GanttAssignmentsSettingsBuilder(GanttAssignmentsSettings container, ViewContext viewContext, IUrlGenerator urlGenerator)
        {
            Container = container;
            this.viewContext = viewContext;
            this.urlGenerator = urlGenerator;
        }

        protected GanttAssignmentsSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The field of the assignment data item which represents the resource id.
        /// </summary>
        /// <param name="value">The value for DataResourceIdField</param>
        public GanttAssignmentsSettingsBuilder<TAssingmentModel> DataResourceIdField(string value)
        {
            Container.DataResourceIdField = value;
            return this;
        }

        /// <summary>
        /// The field of the assignment data item which represents the task id.
        /// </summary>
        /// <param name="value">The value for DataTaskIdField</param>
        public GanttAssignmentsSettingsBuilder<TAssingmentModel> DataTaskIdField(string value)
        {
            Container.DataTaskIdField = value;
            return this;
        }

        /// <summary>
        /// The field of the assignment data item which represents the amount of the assigned resource.
        /// </summary>
        /// <param name="value">The value for DataValueField</param>
        public GanttAssignmentsSettingsBuilder<TAssingmentModel> DataValueField(string value)
        {
            Container.DataValueField = value;
            return this;
        }

        /// <summary>
        /// The data source which contains assignment data items.  Can be a JavaScript object which represents a valid data source configuration, a JavaScript array or an existing kendo.data.DataSource
        /// instance.If the dataSource option is set to a JavaScript object or array the widget will initialize a new kendo.data.DataSource instance using that value as data source configuration.If the dataSource option is an existing kendo.data.DataSource instance the widget will use that instance and will not initialize a new one.
        /// </summary>
        /// <param name="value">The value that configures the datasource.</param>
        public GanttAssignmentsSettingsBuilder<TAssingmentModel> DataSource(Action<GanttAssignmentsDataSourceBuilder<TAssingmentModel>> configurator)
        {
            Container.DataSource.Schema.Model = new ModelDescriptor(typeof(TAssingmentModel), Container.ModelMetaDataProvider);
            configurator(new GanttAssignmentsDataSourceBuilder<TAssingmentModel>(Container.DataSource, viewContext, urlGenerator));

            return this;
        }

        /// <summary>
        /// Binds the gantt assignments to a list of objects
        /// </summary>
        /// <param name="dataSource">The dataSource</param>
        public GanttAssignmentsSettingsBuilder<TAssingmentModel> BindTo(IEnumerable dataSource)
        {
            Container.DataSource.Data = dataSource;

            return this;
        }
    }
}
