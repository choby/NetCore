using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisLabelsBorderSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisLabelsBorderSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisLabelsBorderSettingsBuilder(StockChartNavigatorCategoryAxisLabelsBorderSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisLabelsBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
