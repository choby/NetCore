using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesMarkersBorderSettings class
    /// </summary>
    public partial class ChartSeriesMarkersBorderSettings<T> where T : class 
    {
        public string Color { get; set; }
        public ClientHandlerDescriptor ColorHandler { get; set; }

        public double? Width { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (ColorHandler?.HasValue() == true)
            {
                settings["color"] = ColorHandler;
            }
            else if (Color?.HasValue() == true)
            {
               settings["color"] = Color;
            }


            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            return settings;
        }
    }
}
