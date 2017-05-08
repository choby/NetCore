using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI LinearGauge component
    /// </summary>
    public partial class LinearGauge 
    {
        public LinearGaugeGaugeAreaSettings GaugeArea { get; } = new LinearGaugeGaugeAreaSettings();

        public RenderingMode? RenderAs { get; set; }

        public LinearGaugeScaleSettings Scale { get; } = new LinearGaugeScaleSettings();

        public bool? Transitions { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            var gaugeArea = GaugeArea.Serialize();
            if (gaugeArea.Any())
            {
                settings["gaugeArea"] = gaugeArea;
            }

            if (RenderAs.HasValue)
            {
                settings["renderAs"] = RenderAs?.Serialize();
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
