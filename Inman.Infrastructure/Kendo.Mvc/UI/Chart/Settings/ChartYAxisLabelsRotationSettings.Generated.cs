using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartYAxisLabelsRotationSettings class
    /// </summary>
    public partial class ChartYAxisLabelsRotationSettings<T> where T : class 
    {
        public string Align { get; set; }

        public double? Angle { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Align?.HasValue() == true)
            {
                settings["align"] = Align;
            }

            if (Angle.HasValue)
            {
                settings["angle"] = Angle;
            }

            return settings;
        }
    }
}
