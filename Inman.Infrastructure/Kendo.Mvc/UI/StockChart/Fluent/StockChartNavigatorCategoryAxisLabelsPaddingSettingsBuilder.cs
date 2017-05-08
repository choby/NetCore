using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisLabelsPaddingSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisLabelsPaddingSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisLabelsPaddingSettingsBuilder(StockChartNavigatorCategoryAxisLabelsPaddingSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisLabelsPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
