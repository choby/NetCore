using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI LinearGaugePointerBorderSettings class
    /// </summary>
    public partial class LinearGaugePointerBorderSettings 
    {
        public string Color { get; set; }

        public ChartDashType? DashType { get; set; }

        public double? Width { get; set; }

        public double? Opacity { get; set; }

        public LinearGauge LinearGauge { get; set; }

        public Dictionary<string, object> Serialize()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (DashType.HasValue)
            {
                settings["dashType"] = DashType?.Serialize();
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            return settings;
        }
    }
}
