using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadialGaugeScaleMinorTicksSettings class
    /// </summary>
    public partial class RadialGaugeScaleMinorTicksSettings 
    {
        /// <summary>
        /// Gets or sets the ticks dash type.
        /// </summary>
        public ChartDashType? DashType
        {
            get;
            set;
        }

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            if (DashType.HasValue)
            {
                settings["dashType"] = DashType?.Serialize();
            }

            return settings;
        }
    }
}
