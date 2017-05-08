using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsCrosshairTooltipPaddingSettings
    /// </summary>
    public partial class ChartAxisDefaultsCrosshairTooltipPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsCrosshairTooltipPaddingSettingsBuilder(ChartAxisDefaultsCrosshairTooltipPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsCrosshairTooltipPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
