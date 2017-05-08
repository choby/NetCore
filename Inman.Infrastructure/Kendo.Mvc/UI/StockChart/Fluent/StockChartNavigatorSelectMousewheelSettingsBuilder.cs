using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSelectMousewheelSettings
    /// </summary>
    public partial class StockChartNavigatorSelectMousewheelSettingsBuilder<T>
        where T : class 
    {
        public StockChartNavigatorSelectMousewheelSettingsBuilder(StockChartNavigatorSelectMousewheelSettings<T> container)
        {
            Container = container;
        }

        protected StockChartNavigatorSelectMousewheelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
