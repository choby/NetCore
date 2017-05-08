using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartZoomableSettings
    /// </summary>
    public partial class ChartZoomableSettingsBuilder<T>
        where T : class 
    {
        public ChartZoomableSettingsBuilder(ChartZoomableSettings<T> container)
        {
            Container = container;
        }

        protected ChartZoomableSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
