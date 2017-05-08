using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttResourcesSettings
    /// </summary>
    public partial class GanttResourcesSettingsBuilder
    {
        private readonly ViewContext viewContext;
        private readonly IUrlGenerator urlGenerator;

        public GanttResourcesSettingsBuilder(GanttResourcesSettings container, ViewContext viewContext, IUrlGenerator urlGenerator)
        {
            Container = container;
            this.viewContext = viewContext;
            this.urlGenerator = urlGenerator;
        }

        protected GanttResourcesSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// The field of the resource data item containing the format of the resource value, which could be assigned to a gantt task.
        /// The data item format value could be any valid kendo format.
        /// </summary>
        /// <param name="value">The value for DataFormatField</param>
        public GanttResourcesSettingsBuilder DataFormatField(string value)
        {
            Container.DataFormatField = value;
            return this;
        }

        /// <summary>
        /// The field of the resource data item which contains the resource color.
        /// </summary>
        /// <param name="value">The value for DataColorField</param>
        public GanttResourcesSettingsBuilder DataColorField(string value)
        {
            Container.DataColorField = value;
            return this;
        }

        /// <summary>
        /// The field of the resource data item which represents the resource text.
        /// </summary>
        /// <param name="value">The value for DataTextField</param>
        public GanttResourcesSettingsBuilder DataTextField(string value)
        {
            Container.DataTextField = value;
            return this;
        }

        /// <summary>
        /// The field of the gantt task which contains the assigned resource objects.
        /// </summary>
        /// <param name="value">The value for Field</param>
        public GanttResourcesSettingsBuilder Field(string value)
        {
            Container.Field = value;
            return this;
        }

        /// <summary>
        /// The data source which contains resource data items.  Can be a JavaScript object which represents a valid data source configuration, a JavaScript array or an existing kendo.data.DataSource
        /// instance.If the dataSource option is set to a JavaScript object or array the widget will initialize a new kendo.data.DataSource instance using that value as data source configuration.If the dataSource option is an existing kendo.data.DataSource instance the widget will use that instance and will not initialize a new one.
        /// </summary>
        /// <param name="value">The value that configures the datasource.</param>
        public GanttResourcesSettingsBuilder DataSource(Action<ReadOnlyAjaxDataSourceBuilder<object>> configurator)
        {
            configurator(new ReadOnlyAjaxDataSourceBuilder<object>(Container.DataSource, viewContext, urlGenerator));

            return this;
        }

        /// <summary>
        /// Binds the gantt resources to a list of objects
        /// </summary>
        /// <param name="dataSource">The dataSource</param>
        public GanttResourcesSettingsBuilder BindTo(IEnumerable dataSource)
        {
            Container.DataSource.Data = dataSource;

            return this;
        }
    }
}
