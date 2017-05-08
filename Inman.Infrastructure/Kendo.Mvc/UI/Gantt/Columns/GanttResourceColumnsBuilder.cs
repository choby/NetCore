using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kendo.Mvc.UI.Fluent
{
    public class GanttResourceColumnBuilder<TTaskModel, TDependenciesModel> : GanttColumnBuilder<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask where TDependenciesModel : class, IGanttDependency
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GanttResourceColumnBuilder{T}"/> class.
        /// </summary>
        /// <param name="column">The column.</param>
        public GanttResourceColumnBuilder(GanttColumn<TTaskModel, TDependenciesModel> column)
            : base(column)
        {
        }
    }
}
