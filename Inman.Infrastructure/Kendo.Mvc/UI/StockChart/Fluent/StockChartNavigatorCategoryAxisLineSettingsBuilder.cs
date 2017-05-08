using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisLineSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisLineSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisLineSettingsBuilder(StockChartNavigatorCategoryAxisLineSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
