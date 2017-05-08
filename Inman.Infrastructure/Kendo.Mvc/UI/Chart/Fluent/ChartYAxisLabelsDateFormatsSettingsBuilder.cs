using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisLabelsDateFormatsSettings
    /// </summary>
    public partial class ChartYAxisLabelsDateFormatsSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisLabelsDateFormatsSettingsBuilder(ChartYAxisLabelsDateFormatsSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisLabelsDateFormatsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
