using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPlotAreaMarginSettings
    /// </summary>
    public partial class ChartPlotAreaMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartPlotAreaMarginSettingsBuilder(ChartPlotAreaMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartPlotAreaMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
