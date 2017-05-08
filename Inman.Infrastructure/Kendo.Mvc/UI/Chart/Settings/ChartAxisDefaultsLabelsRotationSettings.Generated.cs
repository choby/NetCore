using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartAxisDefaultsLabelsRotationSettings class
    /// </summary>
    public partial class ChartAxisDefaultsLabelsRotationSettings<T> where T : class 
    {
        public double? Angle { get; set; }

        public ChartAxisLabelRotationAlignment? Align { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Angle.HasValue)
            {
                settings["angle"] = Angle;
            }

            if (Align.HasValue)
            {
                settings["align"] = Align?.Serialize();
            }

            return settings;
        }
    }
}
