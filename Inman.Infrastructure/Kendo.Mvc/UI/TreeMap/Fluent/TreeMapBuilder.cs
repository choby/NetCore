using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI TreeMap
    /// </summary>
    public partial class TreeMapBuilder: WidgetBuilderBase<TreeMap, TreeMapBuilder>
        
    {
        public TreeMapBuilder(TreeMap component) : base(component)
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
        ///             .Action("Action", "TreeMap")
        ///         )
        ///     )
        ///  %&gt;
        /// </code>
        /// </example>
        public TreeMapBuilder DataSource(Action<HierarchicalDataSourceBuilder<object>> configurator)
        {
            configurator(new HierarchicalDataSourceBuilder<object>(Component.DataSource, this.Component.ViewContext, this.Component.UrlGenerator));

            return this;
        }

        /// <summary>
        /// The default colors for the treemap tiles. When all colors are used, new colors are pulled from the start again.
        /// </summary>
        /// <param name="configurator">The add action.</param>
        public TreeMapBuilder Colors(Action<TreeMapColorRangeFactory> configurator)
        {
            configurator(new TreeMapColorRangeFactory(Component));

            return this;
        }
    }
}

