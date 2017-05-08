using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesTooltipPaddingSettings
    /// </summary>
    public partial class ChartSeriesTooltipPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesTooltipPaddingSettingsBuilder(ChartSeriesTooltipPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesTooltipPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
