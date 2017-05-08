using Kendo.Mvc.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kendo.Mvc.UI
{
    public class GanttResourceColumn<TTaskModel, TDependenciesModel> : GanttColumn<TTaskModel, TDependenciesModel>
        where TTaskModel : class, IGanttTask where TDependenciesModel : class, IGanttDependency
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GanttResourceColumn{TTaskModel}"/> class.
        /// </summary>
        /// <param name="Gantt"></param>
        /// <param name="expression"></param>
        public GanttResourceColumn(string fieldName)
            :base()
        {
            Field = fieldName;
            Title = fieldName.AsTitle();
        }
    }
}
