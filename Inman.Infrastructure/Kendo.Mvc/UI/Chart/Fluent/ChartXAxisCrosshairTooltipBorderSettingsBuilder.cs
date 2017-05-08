using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisCrosshairTooltipBorderSettings
    /// </summary>
    public partial class ChartXAxisCrosshairTooltipBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisCrosshairTooltipBorderSettingsBuilder(ChartXAxisCrosshairTooltipBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisCrosshairTooltipBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
