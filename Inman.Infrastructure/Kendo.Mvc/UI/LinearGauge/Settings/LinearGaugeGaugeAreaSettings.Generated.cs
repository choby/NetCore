using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI LinearGaugeGaugeAreaSettings class
    /// </summary>
    public partial class LinearGaugeGaugeAreaSettings 
    {
        public LinearGaugeGaugeAreaBorderSettings Border { get; } = new LinearGaugeGaugeAreaBorderSettings();

        public double? Height { get; set; }

        public LinearGaugeGaugeAreaMarginSettings Margin { get; } = new LinearGaugeGaugeAreaMarginSettings();

        public double? Width { get; set; }

        public string Background { get; set; }


        public LinearGauge LinearGauge { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            var margin = Margin.Serialize();
            if (margin.Any())
            {
                settings["margin"] = margin;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            if (Background?.HasValue() == true)
            {
                settings["background"] = Background;
            }

            return settings;
        }
    }
}
