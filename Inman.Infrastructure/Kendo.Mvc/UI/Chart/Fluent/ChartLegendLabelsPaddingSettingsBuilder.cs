using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendLabelsPaddingSettings
    /// </summary>
    public partial class ChartLegendLabelsPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartLegendLabelsPaddingSettingsBuilder(ChartLegendLabelsPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartLegendLabelsPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
