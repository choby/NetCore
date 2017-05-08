using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesHighlightLineSettings
    /// </summary>
    public partial class ChartSeriesHighlightLineSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesHighlightLineSettingsBuilder(ChartSeriesHighlightLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesHighlightLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
