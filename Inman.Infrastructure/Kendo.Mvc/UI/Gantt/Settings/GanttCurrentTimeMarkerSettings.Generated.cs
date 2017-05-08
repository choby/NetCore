using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttCurrentTimeMarkerSettings class
    /// </summary>
    public partial class GanttCurrentTimeMarkerSettings<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public double? UpdateInterval { get; set; }

        public bool? Enabled { get; set; }

        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (UpdateInterval.HasValue)
            {
                settings["updateInterval"] = UpdateInterval;
            }

            return settings;
        }
    }
}
