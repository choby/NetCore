using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendLabelsMarginSettings
    /// </summary>
    public partial class ChartLegendLabelsMarginSettingsBuilder<T>
        where T : class 
    {
        public ChartLegendLabelsMarginSettingsBuilder(ChartLegendLabelsMarginSettings<T> container)
        {
            Container = container;
        }

        protected ChartLegendLabelsMarginSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
