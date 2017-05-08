using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisCrosshairTooltipSettings
    /// </summary>
    public partial class ChartValueAxisCrosshairTooltipSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisCrosshairTooltipSettingsBuilder(ChartValueAxisCrosshairTooltipSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisCrosshairTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
