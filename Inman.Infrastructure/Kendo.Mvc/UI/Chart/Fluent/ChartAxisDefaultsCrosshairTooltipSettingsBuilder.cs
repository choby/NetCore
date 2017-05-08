using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsCrosshairTooltipSettings
    /// </summary>
    public partial class ChartAxisDefaultsCrosshairTooltipSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsCrosshairTooltipSettingsBuilder(ChartAxisDefaultsCrosshairTooltipSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsCrosshairTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
