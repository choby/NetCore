using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisTitleMarginSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisTitleMarginSettingsBuilder(StockChartNavigatorCategoryAxisTitleMarginSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisTitleMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
