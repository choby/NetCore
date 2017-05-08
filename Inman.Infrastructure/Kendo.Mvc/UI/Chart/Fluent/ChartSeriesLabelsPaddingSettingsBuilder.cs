using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsPaddingSettings
    /// </summary>
    public partial class ChartSeriesLabelsPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsPaddingSettingsBuilder(ChartSeriesLabelsPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
