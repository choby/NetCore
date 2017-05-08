using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisCrosshairTooltipPaddingSettings
    /// </summary>
    public partial class ChartXAxisCrosshairTooltipPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisCrosshairTooltipPaddingSettingsBuilder(ChartXAxisCrosshairTooltipPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisCrosshairTooltipPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
