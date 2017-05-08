using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadialGaugePointer class
    /// </summary>
    public partial class RadialGaugePointer 
    {
        public RadialGaugePointerCapSettings Cap { get; } = new RadialGaugePointerCapSettings();

        public string Color { get; set; }

        public double? Value { get; set; }

        public double? Opacity { get; set; }

        public RadialGauge RadialGauge { get; set; }

        public Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            var cap = Cap.Serialize();
            if (cap.Any())
            {
                settings["cap"] = cap;
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (Value.HasValue)
            {
                settings["value"] = Value;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            return settings;
        }
    }
}
