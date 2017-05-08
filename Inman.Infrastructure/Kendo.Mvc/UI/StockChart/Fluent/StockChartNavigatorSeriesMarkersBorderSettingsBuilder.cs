using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesMarkersBorderSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesMarkersBorderSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesMarkersBorderSettingsBuilder(StockChartNavigatorSeriesMarkersBorderSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesMarkersBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
