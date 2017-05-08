using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisMajorTicksSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisMajorTicksSettingsBuilder(StockChartNavigatorCategoryAxisMajorTicksSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisMajorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
