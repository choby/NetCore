using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadialGaugePointerCapSettings class
    /// </summary>
    public partial class RadialGaugePointerCapSettings 
    {
        public string Color { get; set; }

        public double? Size { get; set; }

        public double? Opacity { get; set; }

        public RadialGauge RadialGauge { get; set; }

        public Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (Size.HasValue)
            {
                settings["size"] = Size;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            return settings;
        }
    }
}
