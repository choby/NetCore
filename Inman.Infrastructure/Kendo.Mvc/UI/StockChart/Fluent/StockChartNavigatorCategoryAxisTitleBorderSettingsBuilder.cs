using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisTitleBorderSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisTitleBorderSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisTitleBorderSettingsBuilder(StockChartNavigatorCategoryAxisTitleBorderSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisTitleBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
