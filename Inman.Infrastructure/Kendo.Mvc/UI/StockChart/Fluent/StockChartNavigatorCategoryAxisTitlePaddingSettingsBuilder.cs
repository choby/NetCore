using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisTitlePaddingSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisTitlePaddingSettingsBuilder(StockChartNavigatorCategoryAxisTitlePaddingSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisTitlePaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
