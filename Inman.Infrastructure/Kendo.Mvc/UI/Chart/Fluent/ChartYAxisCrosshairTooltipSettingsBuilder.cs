using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisCrosshairTooltipSettings
    /// </summary>
    public partial class ChartYAxisCrosshairTooltipSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisCrosshairTooltipSettingsBuilder(ChartYAxisCrosshairTooltipSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisCrosshairTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
