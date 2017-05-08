using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI MapLayerDefaultsMarkerSettings class
    /// </summary>
    public abstract class MapBaseLayerSettings
    {
        private MapMarkerTooltip tooltip;

        protected abstract ViewContext ViewContext { get; }

        public MapMarkerTooltip Tooltip
        {
            get
            {
                if (tooltip == null && ViewContext != null)
                {
                    tooltip = new MapMarkerTooltip(ViewContext);
                }

                return tooltip;
            }
        }

        protected void SerializeTooltip(IDictionary<string, object> settings)
        {
            if (tooltip != null)
            {
                var tooltipSettings = tooltip.Serialize();
                if (tooltipSettings.Any())
                {
                    settings["tooltip"] = tooltipSettings;
                }
            }
        }
    }
}
