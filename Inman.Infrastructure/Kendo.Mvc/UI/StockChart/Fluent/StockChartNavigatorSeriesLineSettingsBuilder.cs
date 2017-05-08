using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesLineSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesLineSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesLineSettingsBuilder(StockChartNavigatorSeriesLineSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
