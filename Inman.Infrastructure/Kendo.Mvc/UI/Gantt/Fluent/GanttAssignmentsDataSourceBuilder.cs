using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent interface for configuring the Gantt assignments <see cref="DataSource"/>.
    /// </summary>
    public class GanttAssignmentsDataSourceBuilder<TAssingmentModel> : FilterableAjaxDataSourceBuilder<TAssingmentModel, GanttAssignmentsDataSourceBuilder<TAssingmentModel>>
        where TAssingmentModel : class
    {
        public GanttAssignmentsDataSourceBuilder(DataSource dataSource, ViewContext viewContext, IUrlGenerator urlGenerator)
            : base(dataSource, viewContext, urlGenerator)
        {
        }
    }
}
