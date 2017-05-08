using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisLabelsDateFormatsSettings
    /// </summary>
    public partial class ChartXAxisLabelsDateFormatsSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisLabelsDateFormatsSettingsBuilder(ChartXAxisLabelsDateFormatsSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisLabelsDateFormatsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
