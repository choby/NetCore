using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesHighlightLineSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesHighlightLineSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesHighlightLineSettingsBuilder(StockChartNavigatorSeriesHighlightLineSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesHighlightLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
