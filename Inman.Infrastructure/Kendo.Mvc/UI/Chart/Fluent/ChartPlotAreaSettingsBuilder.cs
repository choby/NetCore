using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPlotAreaSettings
    /// </summary>
    public partial class ChartPlotAreaSettingsBuilder<T>
        where T : class 
    {
        public ChartPlotAreaSettingsBuilder(ChartPlotAreaSettings<T> container)
        {
            Container = container;
        }

        protected ChartPlotAreaSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
