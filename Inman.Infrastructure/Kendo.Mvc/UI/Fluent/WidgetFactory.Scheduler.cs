using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    public partial class WidgetFactory<TModel>
    {
        /// <summary>
        /// Creates a new <see cref="Scheduler{T}"/>.
        /// </summary>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Scheduler&lt;SchedulerEvent&gt;()
        ///             .Name("Scheduler")
        /// %&gt;
        /// </code>
        /// </example>
        public virtual SchedulerBuilder<T> Scheduler<T>() where T : class, ISchedulerEvent
        {
            return new SchedulerBuilder<T>(new Scheduler<T>(HtmlHelper.ViewContext));
        }

    }
}