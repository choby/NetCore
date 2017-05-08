using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisCrosshairTooltipPaddingSettings
    /// </summary>
    public partial class ChartValueAxisCrosshairTooltipPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisCrosshairTooltipPaddingSettingsBuilder(ChartValueAxisCrosshairTooltipPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisCrosshairTooltipPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
