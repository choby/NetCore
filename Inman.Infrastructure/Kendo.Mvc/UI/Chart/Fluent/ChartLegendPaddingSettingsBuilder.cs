using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendPaddingSettings
    /// </summary>
    public partial class ChartLegendPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartLegendPaddingSettingsBuilder(ChartLegendPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartLegendPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
