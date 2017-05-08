using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesMarkersSettings
    /// </summary>
    public partial class ChartSeriesMarkersSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesMarkersSettingsBuilder(ChartSeriesMarkersSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesMarkersSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
