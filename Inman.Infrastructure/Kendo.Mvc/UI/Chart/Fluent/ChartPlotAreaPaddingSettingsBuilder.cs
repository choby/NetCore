using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPlotAreaPaddingSettings
    /// </summary>
    public partial class ChartPlotAreaPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartPlotAreaPaddingSettingsBuilder(ChartPlotAreaPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartPlotAreaPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
