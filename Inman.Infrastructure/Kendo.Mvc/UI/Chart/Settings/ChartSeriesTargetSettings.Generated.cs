using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesTargetSettings class
    /// </summary>
    public partial class ChartSeriesTargetSettings<T> where T : class 
    {
        public ChartSeriesTargetBorderSettings<T> Border { get; } = new ChartSeriesTargetBorderSettings<T>();

        public string Color { get; set; }
        public ClientHandlerDescriptor ColorHandler { get; set; }

        public ChartSeriesTargetLineSettings<T> Line { get; } = new ChartSeriesTargetLineSettings<T>();


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
            }

            if (ColorHandler?.HasValue() == true)
            {
                settings["color"] = ColorHandler;
            }
            else if (Color?.HasValue() == true)
            {
               settings["color"] = Color;
            }


            var line = Line.Serialize();
            if (line.Any())
            {
                settings["line"] = line;
            }

            return settings;
        }
    }
}
