using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsToPaddingSettings
    /// </summary>
    public partial class ChartSeriesLabelsToPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsToPaddingSettingsBuilder(ChartSeriesLabelsToPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsToPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
