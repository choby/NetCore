using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="PivotGrid{T}"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PivotGrid()
        ///             .Name("PivotGrid")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual PivotGridBuilder<object> PivotGrid()
        {
            return new PivotGridBuilder<object>(new PivotGrid<object>(HtmlHelper.ViewContext));
        }

        /// <summary>
        /// Creates a new <see cref="PivotGrid{T}"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().PivotGrid&lt;EventData&gt;()
        ///             .Name("PivotGrid")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual PivotGridBuilder<T> PivotGrid<T>() where T : class
        {
            return new PivotGridBuilder<T>(new PivotGrid<T>(HtmlHelper.ViewContext));
        }
    }
}