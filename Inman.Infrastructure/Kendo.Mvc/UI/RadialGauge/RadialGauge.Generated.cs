using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadialGauge component
    /// </summary>
    public partial class RadialGauge 
    {
        public RadialGaugeGaugeAreaSettings GaugeArea { get; } = new RadialGaugeGaugeAreaSettings();

        public RadialGaugeScaleSettings Scale { get; } = new RadialGaugeScaleSettings();

        public bool? Transitions { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            var gaugeArea = GaugeArea.Serialize();
            if (gaugeArea.Any())
            {
                settings["gaugeArea"] = gaugeArea;
            }

            var scale = Scale.Serialize();
            if (scale.Any())
            {
                settings["scale"] = scale;
            }

            return settings;
        }
    }
}
