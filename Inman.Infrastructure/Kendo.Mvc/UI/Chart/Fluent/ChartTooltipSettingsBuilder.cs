using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartTooltipSettings
    /// </summary>
    public partial class ChartTooltipSettingsBuilder<T>
        where T : class 
    {
        public ChartTooltipSettingsBuilder(ChartTooltipSettings<T> container)
        {
            Container = container;
        }

        protected ChartTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
