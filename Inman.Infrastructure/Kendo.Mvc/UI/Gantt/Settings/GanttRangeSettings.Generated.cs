using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttRangeSettings class
    /// </summary>
    public partial class GanttRangeSettings<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }


        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Start.HasValue)
            {
                settings["start"] = Start;
            }

            if (End.HasValue)
            {
                settings["end"] = End;
            }

            return settings;
        }
    }
}
