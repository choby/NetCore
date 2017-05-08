using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TreeList
    /// </summary>
    public partial class TreeListBuilder<T>: WidgetBuilderBase<TreeList<T>, TreeListBuilder<T>>
        where T : class 
    {
        public TreeListBuilder(TreeList<T> component) : base(component)
        {
        }

		/// <summary>
		/// Configure the DataSource of the component
		/// </summary>
		/// <param name="configurator">The action that configures the <see cref="DataSource"/>.</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().TreeMap()
		///     .Name("treeMap")
		///     .DataSource(dataSource => dataSource
		///         .Read(read => read
		///             .Action("_PopulationUS", "TreeMap")
		///         )
		///     )
		///  %&gt;
		/// </code>
		/// </example>
		public TreeListBuilder<T> DataSource(Action<TreeListAjaxDataSourceBuilder<T>> configurator)
		{
			configurator(new TreeListAjaxDataSourceBuilder<T>(Component.DataSource, Component.ViewContext, Component.UrlGenerator));

			return this;
		}

        public TreeListBuilder<T> DataSource(string dataSourceId)
        {
            Component.DataSourceId = dataSourceId;

            return this;
        }

        /// <summary>
        /// If set to true the user would be able to select treelist rows. By default selection is disabled.Can also be set to the following string values:
        /// </summary>
        public TreeListBuilder<T> Selectable()
		{
			Container.Selectable.Enabled = true;
			return this;
		}
	}
}

