using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsCrosshairTooltipBorderSettings
    /// </summary>
    public partial class ChartAxisDefaultsCrosshairTooltipBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsCrosshairTooltipBorderSettingsBuilder(ChartAxisDefaultsCrosshairTooltipBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsCrosshairTooltipBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
