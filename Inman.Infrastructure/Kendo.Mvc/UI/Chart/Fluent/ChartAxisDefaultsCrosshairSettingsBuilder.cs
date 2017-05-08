using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsCrosshairSettings
    /// </summary>
    public partial class ChartAxisDefaultsCrosshairSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsCrosshairSettingsBuilder(ChartAxisDefaultsCrosshairSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsCrosshairSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
