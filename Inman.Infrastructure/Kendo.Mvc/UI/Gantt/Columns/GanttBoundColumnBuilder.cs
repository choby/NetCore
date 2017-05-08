using System;
using Kendo.Mvc.Infrastructure;

namespace Kendo.Mvc.UI.Fluent
{
    public class GanttBoundColumnBuilder<TTaskModel, TDependenciesModel> : GanttColumnBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask where TDependenciesModel : class, IGanttDependency
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GanttBoundColumnBuilder{T}"/> class.
        /// </summary>
        /// <param name="column">The column.</param>
        public GanttBoundColumnBuilder(GanttColumn<TTaskModel, TDependenciesModel> column)
            : base(column)
        {
        }
    }
}