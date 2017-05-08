using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendBorderSettings
    /// </summary>
    public partial class ChartLegendBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartLegendBorderSettingsBuilder(ChartLegendBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartLegendBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
