using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisTitleSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisTitleSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisTitleSettingsBuilder(StockChartNavigatorCategoryAxisTitleSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisTitleSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
