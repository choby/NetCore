using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisLabelsPaddingSettings
    /// </summary>
    public partial class ChartYAxisLabelsPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisLabelsPaddingSettingsBuilder(ChartYAxisLabelsPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisLabelsPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
