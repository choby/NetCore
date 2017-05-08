using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Gantt
    /// </summary>
    public partial class GanttBuilder<TTaskModel, TDependenciesModel>: WidgetBuilderBase<Gantt<TTaskModel, TDependenciesModel>, GanttBuilder<TTaskModel, TDependenciesModel>>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttBuilder(Gantt<TTaskModel, TDependenciesModel> component) : base(component)
        {
        }

        /// <summary>
        /// Configures the DataSource options.
        /// </summary>
        /// <param name="configurator">The DataSource configurator action.</param>
        /// <example>
        /// <code lang="Razor">
        ///  @(Html.Kendo().Gantt&lt;TaskViewModel, DependencyViewModel&gt;()
        ///     .Name("Gantt")
        ///     .DataSource(source =&gt;
        ///     {
        ///         source.Read(read =&gt;
        ///         {
        ///             read.Action("Read", "Gantt");
        ///         });
        ///     })
        /// )
        /// </code>
        /// </example>
        public GanttBuilder<TTaskModel, TDependenciesModel>  DataSource(Action<GanttDataSourceBuilder<TTaskModel>> configurator)
        {
            configurator(new GanttDataSourceBuilder<TTaskModel>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));

            return this;
        }
        public GanttBuilder<TTaskModel, TDependenciesModel> DataSource(string dataSourceId)
        {
            Component.DataSourceId = dataSourceId;
            return this;
        }

        public GanttBuilder<TTaskModel, TDependenciesModel> DependenciesDataSource(string dataSourceId)
        {
            Component.DependenciesDataSourceId = dataSourceId;
            return this;
        }

        /// <summary>
        /// Configures the dependencies DataSource options.
        /// </summary>
        /// <param name="configurator">The DataSource configurator action.</param>
        /// <example>
        /// <code lang="Razor">
        /// @(Html.Kendo().Gantt&lt;TaskViewModel, DependencyViewModel&gt;()
        ///     .Name("Gantt")
        ///     .DataSource(source =&gt;
        ///     {
        ///         source.Read(read =&gt;
        ///         {
        ///             read.Action("Read", "Gantt");
        ///         });
        ///     })
        ///     .DependenciesDataSource(source =&gt;
        ///     {
        ///         source.Read(read =&gt;
        ///         {
        ///             read.Action("Read", "Gantt");
        ///         });
        ///     })
        ///  )
        /// </code>
        /// </example>
        public GanttBuilder<TTaskModel, TDependenciesModel> DependenciesDataSource(Action<GanttDependenciesDataSourceBuilder<TDependenciesModel>> configurator)
        {
            configurator(new GanttDependenciesDataSourceBuilder<TDependenciesModel>(Component.DependenciesDataSource, Component.ViewContext, Component.UrlGenerator));

            return this;
        }

        /// <summary>
        /// The configuration of the assignments of the gantt resources. An assignment is a one-to-one mapping between a gantt task and a gantt resource containing the number of units for which a resource is assigned to a task.
        /// </summary>
        /// <param name="configurator">The configurator for the assignments setting.</param>
        public GanttBuilder<TTaskModel, TDependenciesModel> Assignments<TAssingmentModel>(Action<GanttAssignmentsSettingsBuilder<TAssingmentModel>> configurator)
            where TAssingmentModel : class
        {
            configurator(new GanttAssignmentsSettingsBuilder<TAssingmentModel>(Component.Assignments, Component.ViewContext, Component.UrlGenerator));

            return this;
        }

        /// <summary>
        /// The configuration of the gantt resource(s). A gantt resource is optional metadata that can be associated
        /// with a gantt task.
        /// </summary>
        /// <param name="configurator">The configurator for the resources setting.</param>
        public GanttBuilder<TTaskModel, TDependenciesModel> Resources(Action<GanttResourcesSettingsBuilder> configurator)
        {
            configurator(new GanttResourcesSettingsBuilder(Component.Resources, Component.ViewContext, Component.UrlGenerator));

            return this;
        }
    }
}

