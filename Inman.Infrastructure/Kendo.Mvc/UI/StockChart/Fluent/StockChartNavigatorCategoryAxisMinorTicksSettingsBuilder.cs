using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisMinorTicksSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisMinorTicksSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisMinorTicksSettingsBuilder(StockChartNavigatorCategoryAxisMinorTicksSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisMinorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
