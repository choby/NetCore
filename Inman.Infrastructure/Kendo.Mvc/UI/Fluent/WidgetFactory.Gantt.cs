using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="Gantt"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Gantt()
        /// %&gt;
        /// </code>
        /// </example>
        public virtual GanttBuilder<TTaskModel, TDependenciesModel> Gantt<TTaskModel, TDependenciesModel>()
            where TTaskModel : class, IGanttTask where TDependenciesModel : class, IGanttDependency
        {
            return new GanttBuilder<TTaskModel, TDependenciesModel>(new Gantt<TTaskModel, TDependenciesModel>(HtmlHelper.ViewContext));
        }

        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.Gantt{T}"/> bound to the specified data source.
        /// </summary>
        /// <typeparam name="T">The type of the data item</typeparam>
        /// <param name="dataSource">The data source.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Gantt(ViewBag.Tasks)
        ///             .Name("Gantt")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual GanttBuilder<TTaskModel, TDependenciesModel> Gantt<TTaskModel, TDependenciesModel>(IEnumerable<TTaskModel> dataSource, IEnumerable<TDependenciesModel> dependenciesDataSource = null)
            where TTaskModel : class, IGanttTask where TDependenciesModel : class, IGanttDependency
        {
            GanttBuilder<TTaskModel, TDependenciesModel> builder = Gantt<TTaskModel, TDependenciesModel>();

            builder.Component.DataSource.Data = dataSource;

            if (dependenciesDataSource != null)
            {
                builder.Component.DependenciesDataSource.Data = dependenciesDataSource;
            }

            return builder;
        }

        /// <summary>
        /// Creates a new <see cref="Kendo.Mvc.UI.Gantt{T}"/> bound an item in ViewData.
        /// </summary>
        /// <typeparam name="T">Type of the data item</typeparam>
        /// <param name="dataSourceViewDataKey">The data source view data key.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Gantt("tasks")
        ///             .Name("Gantt")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual GanttBuilder<TTaskModel, TDependenciesModel> Gantt<TTaskModel, TDependenciesModel>(string dataSourceViewDataKey, string dependenciesDataSourceViewDataKey = null)
            where TTaskModel : class, IGanttTask
            where TDependenciesModel : class, IGanttDependency
        {
            GanttBuilder<TTaskModel, TDependenciesModel> builder = Gantt<TTaskModel, TDependenciesModel>();

            builder.Component.DataSource.Data = HtmlHelper.ViewContext.ViewData.Eval(dataSourceViewDataKey) as IEnumerable<TTaskModel>;

            if (!string.IsNullOrWhiteSpace(dependenciesDataSourceViewDataKey))
            {
                builder.Component.DependenciesDataSource.Data = HtmlHelper.ViewContext.ViewData.Eval(dependenciesDataSourceViewDataKey) as IEnumerable<TDependenciesModel>;
            }

            return builder;
        }
    }
}