using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartChartAreaMarginSettings
    /// </summary>
    public partial class ChartChartAreaMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartChartAreaMarginSettingsBuilder(ChartChartAreaMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartChartAreaMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
