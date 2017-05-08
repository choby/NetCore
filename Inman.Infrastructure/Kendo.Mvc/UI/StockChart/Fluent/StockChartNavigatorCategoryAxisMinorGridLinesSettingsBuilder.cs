using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisMinorGridLinesSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisMinorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisMinorGridLinesSettingsBuilder(StockChartNavigatorCategoryAxisMinorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisMinorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
