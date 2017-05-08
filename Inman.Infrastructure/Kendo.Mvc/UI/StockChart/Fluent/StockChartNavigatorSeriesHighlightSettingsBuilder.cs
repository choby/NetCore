using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesHighlightSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesHighlightSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesHighlightSettingsBuilder(StockChartNavigatorSeriesHighlightSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesHighlightSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
