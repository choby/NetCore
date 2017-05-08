using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesMarkersBorderSettings
    /// </summary>
    public partial class ChartSeriesMarkersBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesMarkersBorderSettingsBuilder(ChartSeriesMarkersBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesMarkersBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
