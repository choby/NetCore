using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisMajorGridLinesSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisMajorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisMajorGridLinesSettingsBuilder(StockChartNavigatorCategoryAxisMajorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisMajorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
