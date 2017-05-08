using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartTooltipPaddingSettings
    /// </summary>
    public partial class ChartTooltipPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartTooltipPaddingSettingsBuilder(ChartTooltipPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartTooltipPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
