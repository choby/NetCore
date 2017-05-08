using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisLabelsPaddingSettings
    /// </summary>
    public partial class ChartValueAxisLabelsPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisLabelsPaddingSettingsBuilder(ChartValueAxisLabelsPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisLabelsPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
