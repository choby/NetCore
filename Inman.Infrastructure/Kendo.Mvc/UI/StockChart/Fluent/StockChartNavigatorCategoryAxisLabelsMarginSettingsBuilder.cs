using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisLabelsMarginSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisLabelsMarginSettingsBuilder(StockChartNavigatorCategoryAxisLabelsMarginSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisLabelsMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
