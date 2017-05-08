using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisLabelsPaddingSettings
    /// </summary>
    public partial class ChartXAxisLabelsPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisLabelsPaddingSettingsBuilder(ChartXAxisLabelsPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisLabelsPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
