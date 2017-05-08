using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesHighlightBorderSettings
    /// </summary>
    public partial class ChartSeriesHighlightBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesHighlightBorderSettingsBuilder(ChartSeriesHighlightBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesHighlightBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
