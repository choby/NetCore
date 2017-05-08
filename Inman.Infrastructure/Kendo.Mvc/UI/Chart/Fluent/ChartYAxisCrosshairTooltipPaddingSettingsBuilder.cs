using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisCrosshairTooltipPaddingSettings
    /// </summary>
    public partial class ChartYAxisCrosshairTooltipPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisCrosshairTooltipPaddingSettingsBuilder(ChartYAxisCrosshairTooltipPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisCrosshairTooltipPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
