using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<StockChartNavigatorCategoryAxisSettingsPlotBand<T>>
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisSettingsPlotBandFactory<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisSettingsPlotBandFactory(List<StockChartNavigatorCategoryAxisSettingsPlotBand<T>> container)
        {
            Container = container;
        }

        protected List<StockChartNavigatorCategoryAxisSettingsPlotBand<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
