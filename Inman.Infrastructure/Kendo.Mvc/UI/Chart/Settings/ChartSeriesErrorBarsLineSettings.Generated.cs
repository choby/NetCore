using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesErrorBarsLineSettings class
    /// </summary>
    public partial class ChartSeriesErrorBarsLineSettings<T> where T : class 
    {
        public double? Width { get; set; }

        public ChartDashType? DashType { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            if (DashType.HasValue)
            {
                settings["dashType"] = DashType?.Serialize();
            }

            return settings;
        }
    }
}
