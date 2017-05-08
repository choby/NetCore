using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new unbound <see cref="StockChart"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().StockChart()
        ///             .Name("StockChart")
        ///             .Series(series => {
        ///                 series.Bar(new int[] { 1, 2, 3 }).Name("Total Sales");
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public virtual StockChartBuilder<object> StockChart()
        {
            StockChartBuilder<object> builder = StockChart<object>();

            return builder;
        }

        /// <summary>
        /// Creates a <see cref="Kendo.Mvc.UI.StockChart{T}"/>
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().StockChart()
        ///             .Name("StockChart")
        /// );
        /// </code>
        /// </example>
        public virtual StockChartBuilder<T> StockChart<T>() where T : class
        {
            return new StockChartBuilder<T>(new StockChart<T>(HtmlHelper.ViewContext));
        }

        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.StockChart{T}"/> bound to the specified data source.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="data">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().StockChart(Model)
        ///             .Name("StockChart")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual StockChartBuilder<T> StockChart<T>(IEnumerable<T> data) where T : class
        {
            StockChartBuilder<T> builder = StockChart<T>();

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
        public virtual ChartBuilder<T> StockChart<T>(string dataSourceViewDataKey) where T : class
        {
            ChartBuilder<T> builder = Chart<T>();

            builder.Component.Data = HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<T>;

            return builder;
        }
    }
}