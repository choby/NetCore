using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesMarkersSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesMarkersSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesMarkersSettingsBuilder(StockChartNavigatorSeriesMarkersSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesMarkersSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
