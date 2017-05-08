using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesMarkersSettings class
    /// </summary>
    public partial class ChartSeriesMarkersSettings<T> where T : class 
    {
        public string Background { get; set; }
        public ClientHandlerDescriptor BackgroundHandler { get; set; }

        public ChartSeriesMarkersBorderSettings<T> Border { get; } = new ChartSeriesMarkersBorderSettings<T>();

        public double? Size { get; set; }

        public bool? Visible { get; set; }

        public ClientHandlerDescriptor Visual { get; set; }

        public double? Rotation { get; set; }

        public ChartMarkerShape? Type { get; set; }
        public ClientHandlerDescriptor TypeHandler { get; set; }


        public Chart<T> Chart { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (BackgroundHandler?.HasValue() == true)
            {
                settings["background"] = BackgroundHandler;
            }
            else if (Background?.HasValue() == true)
            {
               settings["background"] = Background;
            }


            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
            }

            if (Size.HasValue)
            {
                settings["size"] = Size;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            if (Visual?.HasValue() == true)
            {
                settings["visual"] = Visual;
            }

            if (Rotation.HasValue)
            {
                settings["rotation"] = Rotation;
            }

            if (TypeHandler?.HasValue() == true)
            {
                settings["type"] = TypeHandler;
            }
            else if (Type.HasValue)
            {
                settings["type"] = Type?.Serialize();
            }


            return settings;
        }
    }
}
