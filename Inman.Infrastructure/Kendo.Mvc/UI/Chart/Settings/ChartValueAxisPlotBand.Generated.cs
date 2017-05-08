using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartValueAxisPlotBand class
    /// </summary>
    public partial class ChartValueAxisPlotBand<T> where T : class 
    {
        public string Color { get; set; }

        public object From { get; set; }

        public double? Opacity { get; set; }

        public object To { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (From != null)
            {
                settings["from"] = From;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (To != null)
            {
                settings["to"] = To;
            }

            return settings;
        }
    }
}
