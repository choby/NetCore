using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesHighlightSettings
    /// </summary>
    public partial class ChartSeriesHighlightSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesHighlightSettingsBuilder(ChartSeriesHighlightSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesHighlightSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
