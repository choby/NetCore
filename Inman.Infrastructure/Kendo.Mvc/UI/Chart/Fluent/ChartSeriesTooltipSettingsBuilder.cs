using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesTooltipSettings
    /// </summary>
    public partial class ChartSeriesTooltipSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesTooltipSettingsBuilder(ChartSeriesTooltipSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
