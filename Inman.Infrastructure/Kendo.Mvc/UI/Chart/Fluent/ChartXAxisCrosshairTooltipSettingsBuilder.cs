using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisCrosshairTooltipSettings
    /// </summary>
    public partial class ChartXAxisCrosshairTooltipSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisCrosshairTooltipSettingsBuilder(ChartXAxisCrosshairTooltipSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisCrosshairTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
