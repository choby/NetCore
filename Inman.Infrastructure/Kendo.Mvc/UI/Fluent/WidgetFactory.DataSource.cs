using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.DataSource{T}"/> bound to the specified data item type.
        /// </summary>
        /// <example>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <code lang="CS">
        ///  @(Html.Kendo().DataSource&lt;Order&gt;()
        ///             .Name("DataSource")
        ///             .BindTo(Model)
        /// )
        /// </code>
        /// </example>      
        public virtual DataSourceWidgetBuilder<T> DataSource<T>() where T : class
        {
            return new DataSourceWidgetBuilder<T>(new DataSourceWidget<T>(HtmlHelper.ViewContext));
        }

        ///// <summary>
        ///// Creates a new <see cref="Kendo.Mvc.UI.DataSource{T}"/> bound to the specified data source.
        ///// </summary>
        ///// <typeparam name="T">The type of the data item</typeparam>
        ///// <param name="dataSource">The data source.</param>
        ///// <example>
        ///// <code lang="CS">
        /////  @(Html.Kendo().DataSource(Model)
        /////             .Name("DataSource")
        ///// )
        ///// </code>
        ///// </example>
        //public virtual DataSourceBuilder<T> DataSource<T>(IEnumerable<T> dataSource) where T : class
        //{
        //    var builder = DataSource<T>();

        //    //var builder = new DataSourceBuilder

        //    //builder.Component.Data = dataSource;
        //    builder.DataSource.Data = dataSource;

        //    return builder;
        //}

        ///// <summary>
        ///// Creates a new <see cref="Kendo.Mvc.UI.DataSource{T}"/> bound an item in ViewData.
        ///// </summary>
        ///// <typeparam name="T">Type of the data item</typeparam>
        ///// <param name="dataSourceViewDataKey">The data source view data key.</param>
        ///// <example>
        ///// <code lang="CS">
        /////  @(Html.Kendo().DataSource&lt;Order&gt;("orders")
        /////             .Name("DataSource")
        ///// )
        ///// </code>
        ///// </example>
        //public virtual DataSourceBuilder<T> DataSource<T>(string dataSourceViewDataKey) where T : class
        //{
        //    var builder = DataSource<T>();

        //    builder.DataSource.Data = HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<T>;

        //    return builder;
        //}
    }
}