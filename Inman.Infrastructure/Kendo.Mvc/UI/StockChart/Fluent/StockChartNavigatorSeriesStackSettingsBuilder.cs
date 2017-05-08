using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesStackSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesStackSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesStackSettingsBuilder(StockChartNavigatorSeriesStackSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesStackSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
