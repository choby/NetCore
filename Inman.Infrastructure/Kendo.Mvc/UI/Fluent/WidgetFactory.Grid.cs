using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.Grid{T}"/> bound to the specified data item type.
        /// </summary>
        /// <example>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <code lang="CS">
        ///  @(Html.Kendo().Grid&lt;Order&gt;()
        ///             .Name("Grid")
        ///             .BindTo(Model)
        /// )
        /// </code>
        /// </example>      
        public virtual GridBuilder<T> Grid<T>() where T : class
        {
            return new GridBuilder<T>(new Grid<T>(HtmlHelper.ViewContext));
        }

        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.Grid{T}"/> bound to the specified data source.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  @(Html.Kendo().Grid(Model)
        ///             .Name("Grid")
        /// )
        /// </code>
        /// </example>
        public virtual GridBuilder<T> Grid<T>(IEnumerable<T> dataSource) where T : class
        {
            var builder = Grid<T>();

            builder.Component.DataSource.Data = dataSource;

            return builder;
        }

        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.Grid{T}"/> bound an item in ViewData.
        /// </summary>
        /// <typeparam name="T">Type of the data item</typeparam>
        /// <param name="dataSourceViewDataKey">The data source view data key.</param>
        /// <example>
        /// <code lang="CS">
        ///  @(Html.Kendo().Grid&lt;Order&gt;("orders")
        ///             .Name("Grid")
        /// )
        /// </code>
        /// </example>
        public virtual GridBuilder<T> Grid<T>(string dataSourceViewDataKey) where T : class
        {
            var builder = Grid<T>();

            builder.Component.DataSource.Data = HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<T>;

            return builder;
        }
    }
}