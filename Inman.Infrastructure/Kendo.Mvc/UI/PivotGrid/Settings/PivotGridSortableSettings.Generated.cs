using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI PivotGridSortableSettings class
    /// </summary>
    public partial class PivotGridSortableSettings<T> where T : class 
    {
        public bool? AllowUnsort { get; set; }

        public bool? Enabled { get; set; }

        public PivotGrid<T> PivotGrid { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AllowUnsort.HasValue)
            {
                settings["allowUnsort"] = AllowUnsort;
            }

            return settings;
        }
    }
}
