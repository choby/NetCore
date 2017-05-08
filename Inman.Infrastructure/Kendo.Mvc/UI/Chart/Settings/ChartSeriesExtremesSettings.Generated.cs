using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI ChartSeriesExtremesSettings class
    /// </summary>
    public partial class ChartSeriesExtremesSettings<T> where T : class 
    {
        public string Background { get; set; }
        public ClientHandlerDescriptor BackgroundHandler { get; set; }

        public ChartSeriesExtremesBorderSettings<T> Border { get; } = new ChartSeriesExtremesBorderSettings<T>();

        public double? Size { get; set; }

        public string Type { get; set; }
        public ClientHandlerDescriptor TypeHandler { get; set; }

        public double? Rotation { get; set; }


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

            if (TypeHandler?.HasValue() == true)
            {
                settings["type"] = TypeHandler;
            }
            else if (Type?.HasValue() == true)
            {
               settings["type"] = Type;
            }


            if (Rotation.HasValue)
            {
                settings["rotation"] = Rotation;
            }

            return settings;
        }
    }
}
