using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI LinearGaugePointerTrackSettings class
    /// </summary>
    public partial class LinearGaugePointerTrackSettings 
    {
        public LinearGaugePointerTrackBorderSettings Border { get; } = new LinearGaugePointerTrackBorderSettings();

        public string Color { get; set; }

        public double? Opacity { get; set; }

        public double? Size { get; set; }

        public bool? Visible { get; set; }

        public LinearGauge LinearGauge { get; set; }

        public Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (Size.HasValue)
            {
                settings["size"] = Size;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            return settings;
        }
    }
}
