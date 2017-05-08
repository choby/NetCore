using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisCrosshairTooltipBorderSettings
    /// </summary>
    public partial class ChartValueAxisCrosshairTooltipBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisCrosshairTooltipBorderSettingsBuilder(ChartValueAxisCrosshairTooltipBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisCrosshairTooltipBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
