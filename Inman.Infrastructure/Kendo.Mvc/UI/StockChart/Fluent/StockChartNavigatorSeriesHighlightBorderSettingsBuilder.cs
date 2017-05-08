using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesHighlightBorderSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesHighlightBorderSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesHighlightBorderSettingsBuilder(StockChartNavigatorSeriesHighlightBorderSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesHighlightBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
