using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisSettingsBuilder(StockChartNavigatorCategoryAxisSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
