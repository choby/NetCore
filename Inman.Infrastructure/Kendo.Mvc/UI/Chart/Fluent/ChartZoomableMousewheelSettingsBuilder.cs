using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartZoomableMousewheelSettings
    /// </summary>
    public partial class ChartZoomableMousewheelSettingsBuilder<T>
        where T : class 
    {
        public ChartZoomableMousewheelSettingsBuilder(ChartZoomableMousewheelSettings<T> container)
        {
            Container = container;
        }

        protected ChartZoomableMousewheelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
