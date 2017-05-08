using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ChartAxisDefaultsSettingsPlotBand<T>>
    /// </summary>
    public partial class ChartAxisDefaultsSettingsPlotBandFactory<T>
        where T : class 
    {
        public ChartAxisDefaultsSettingsPlotBandFactory(List<ChartAxisDefaultsSettingsPlotBand<T>> container)
        {
            Container = container;
        }

        protected List<ChartAxisDefaultsSettingsPlotBand<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
