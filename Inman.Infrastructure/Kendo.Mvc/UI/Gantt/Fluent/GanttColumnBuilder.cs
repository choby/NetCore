using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GanttColumn
    /// </summary>
    public partial class GanttColumnBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public GanttColumnBuilder(GanttColumn<TTaskModel, TDependenciesModel> container)
        {
            Container = container;
        }

        protected GanttColumn<TTaskModel, TDependenciesModel> Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets or sets the format for displaying the data.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Gantt(Model)
        ///             .Name("Gantt")
        ///             .Columns(columns => columns.Bound(o => o.OrderDate).Format("{0:dd/MM/yyyy}"))
        /// %&gt;
        /// </code>
        /// </example>        
        public GanttColumnBuilder<TTaskModel, TDependenciesModel> Format(string value)
        {
            // Doing the UrlDecode to allow {0} in ActionLink e.g. Html.ActionLink("Index", "Home", new { id = "{0}" })
            Container.Format = System.Net.WebUtility.UrlDecode(value);

            return this;
        }

        /// <summary>
        /// The width of the column. Numeric values are treated as pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public GanttColumnBuilder<TTaskModel, TDependenciesModel> Width(double value)
        {
            Container.Width = string.Format("{0}px", value);
            return this;
        }
    }
}
