using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesOverlaySettings
    /// </summary>
    public partial class StockChartNavigatorSeriesOverlaySettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesOverlaySettingsBuilder(StockChartNavigatorSeriesOverlaySettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesOverlaySettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
