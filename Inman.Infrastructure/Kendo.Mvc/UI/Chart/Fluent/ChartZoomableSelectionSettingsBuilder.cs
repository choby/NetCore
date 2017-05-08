using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartZoomableSelectionSettings
    /// </summary>
    public partial class ChartZoomableSelectionSettingsBuilder<T>
        where T : class 
    {
        public ChartZoomableSelectionSettingsBuilder(ChartZoomableSelectionSettings<T> container)
        {
            Container = container;
        }

        protected ChartZoomableSelectionSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
