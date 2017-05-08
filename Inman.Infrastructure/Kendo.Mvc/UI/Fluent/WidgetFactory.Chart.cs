using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new unbound <see cref="Chart"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Chart()
        ///             .Name("Chart")
        ///             .Series(series => {
        ///                 series.Bar(new int[] { 1, 2, 3 }).Name("Total Sales");
        ///             })
        /// )
        /// </code>
        /// </example>
        public virtual ChartBuilder<object> Chart()
        {
            return new ChartBuilder<object>(new Chart<object>(HtmlHelper.ViewContext));
        }
        
        /// <summary>
        /// Creates a <see cref="Kendo.Mvc.UI.Chart{T}"/> bound to the specified data item type.
        /// </summary>
        public virtual ChartBuilder<T> Chart<T>() where T : class
        {
            return new ChartBuilder<T>(new Chart<T>(HtmlHelper.ViewContext));
        }

        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.Chart{T}"/> bound to the specified data source.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="data">The data source.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Chart(Model)
        ///             .Name("Chart")
        /// )
        /// </code>
        /// </example>
        public virtual ChartBuilder<T> Chart<T>(IEnumerable<T> data) where T : class
        {
            ChartBuilder<T> builder = Chart<T>();

            builder.Component.Data = data;

            return builder;
        }

        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.Chart{T}"/> bound an item in ViewData.
        /// </summary>
        /// <typeparam name="T">Type of the data item</typeparam>
        /// <param name="dataSourceViewDataKey">The data source view data key.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Chart&lt;SalesData&gt;("sales")
        ///             .Name("Chart")
        /// )
        /// </code>
        /// </example>
        public virtual ChartBuilder<T> Chart<T>(string dataSourceViewDataKey) where T : class
        {
            ChartBuilder<T> builder = Chart<T>();

            builder.Component.Data = HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<T>;

            return builder;
        }
    }
}