using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesTooltipBorderSettings
    /// </summary>
    public partial class ChartSeriesTooltipBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesTooltipBorderSettingsBuilder(ChartSeriesTooltipBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesTooltipBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
