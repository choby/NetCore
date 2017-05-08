using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisCrosshairTooltipBorderSettings
    /// </summary>
    public partial class ChartYAxisCrosshairTooltipBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisCrosshairTooltipBorderSettingsBuilder(ChartYAxisCrosshairTooltipBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisCrosshairTooltipBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
