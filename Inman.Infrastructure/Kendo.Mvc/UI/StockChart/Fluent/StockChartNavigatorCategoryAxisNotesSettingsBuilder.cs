using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorCategoryAxisNotesSettings
    /// </summary>
    public partial class StockChartNavigatorCategoryAxisNotesSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorCategoryAxisNotesSettingsBuilder(StockChartNavigatorCategoryAxisNotesSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorCategoryAxisNotesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
