using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendMarginSettings
    /// </summary>
    public partial class ChartLegendMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartLegendMarginSettingsBuilder(ChartLegendMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartLegendMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
