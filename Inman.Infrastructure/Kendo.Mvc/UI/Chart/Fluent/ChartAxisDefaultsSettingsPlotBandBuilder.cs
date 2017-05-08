using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsSettingsPlotBand
    /// </summary>
    public partial class ChartAxisDefaultsSettingsPlotBandBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsSettingsPlotBandBuilder(ChartAxisDefaultsSettingsPlotBand<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsSettingsPlotBand<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
