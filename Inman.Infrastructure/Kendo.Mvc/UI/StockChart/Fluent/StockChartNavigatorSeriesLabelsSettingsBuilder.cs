using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesLabelsSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesLabelsSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSeriesLabelsSettingsBuilder(StockChartNavigatorSeriesLabelsSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSeriesLabelsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
