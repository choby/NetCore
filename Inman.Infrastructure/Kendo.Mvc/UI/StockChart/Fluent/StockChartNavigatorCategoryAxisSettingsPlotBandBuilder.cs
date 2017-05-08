using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisSettingsPlotBand
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisSettingsPlotBandBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisSettingsPlotBandBuilder(StockChartNavigatorCategoryAxisSettingsPlotBand<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisSettingsPlotBand<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
