using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI LinearGaugeScaleSettingsRange class
    /// </summary>
    public partial class LinearGaugeScaleSettingsRange 
    {
        public double? From { get; set; }

        public double? To { get; set; }

        public double? Opacity { get; set; }

        public string Color { get; set; }


        public LinearGauge LinearGauge { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (From.HasValue)
            {
                settings["from"] = From;
            }

            if (To.HasValue)
            {
                settings["to"] = To;
            }

            if (Opacity.HasValue)
            {
                settings["opacity"] = Opacity;
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            return settings;
        }
    }
}
