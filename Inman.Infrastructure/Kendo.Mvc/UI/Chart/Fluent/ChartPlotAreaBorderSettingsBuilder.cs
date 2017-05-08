using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPlotAreaBorderSettings
    /// </summary>
    public partial class ChartPlotAreaBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartPlotAreaBorderSettingsBuilder(ChartPlotAreaBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartPlotAreaBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
