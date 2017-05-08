using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new unbound <see cref="Sparkline"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        /// &lt;%= Html.Kendo().Sparkline()
        ///             .Name("Sparkline")
        ///             .Series(series => {
        ///                 series.Bar(new int[] { 1, 2, 3 }).Name("Total Sales");
        ///             })
        /// %&gt;
        /// </code>
        /// </example>
        public virtual SparklineBuilder<object> Sparkline()
        {
            SparklineBuilder<object> builder = Sparkline<object>();

            return builder;
        }

        /// <summary>
        /// Creates a <see cref="Kendo.Mvc.UI.Sparkline{T}"/>
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Sparkline()
        ///             .Name("Sparkline")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual SparklineBuilder<T> Sparkline<T>() where T : class
        {
            return new SparklineBuilder<T>(new Sparkline<T>(HtmlHelper.ViewContext));
        }

        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.Sparkline{T}"/> bound to the specified data source.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="data">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Sparkline(Model)
        ///             .Name("Sparkline")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual SparklineBuilder<T> Sparkline<T>(IEnumerable<T> data) where T : class
        {
            SparklineBuilder<T> builder = Sparkline<T>();

            builder.Component.Data = data;

            return builder;
        }

        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.Sparkline{T}"/> bound an item in ViewData.
        /// </summary>
        /// <typeparam name="T">Type of the data item</typeparam>
        /// <param name="dataViewDataKey">The data source view data key.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Sparkline&lt;SalesData&gt;("sales")
        ///             .Name("Sparkline")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual SparklineBuilder<T> Sparkline<T>(string dataSourceViewDataKey) where T : class
        {
            SparklineBuilder<T> builder = Sparkline<T>();

            builder.Component.Data = HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<T>;

            return builder;
        }
    }
}