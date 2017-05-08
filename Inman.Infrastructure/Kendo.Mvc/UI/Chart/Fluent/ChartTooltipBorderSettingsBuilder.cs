using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartTooltipBorderSettings
    /// </summary>
    public partial class ChartTooltipBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartTooltipBorderSettingsBuilder(ChartTooltipBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartTooltipBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
