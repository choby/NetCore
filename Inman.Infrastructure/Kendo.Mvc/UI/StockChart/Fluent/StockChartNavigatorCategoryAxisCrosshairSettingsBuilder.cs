using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisCrosshairSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisCrosshairSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisCrosshairSettingsBuilder(StockChartNavigatorCategoryAxisCrosshairSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisCrosshairSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
