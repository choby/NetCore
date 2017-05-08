using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisCrosshairTooltipSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisCrosshairTooltipSettingsBuilder(StockChartNavigatorCategoryAxisCrosshairTooltipSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisCrosshairTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
