using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisLabelsSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisLabelsSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisLabelsSettingsBuilder(StockChartNavigatorCategoryAxisLabelsSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisLabelsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
