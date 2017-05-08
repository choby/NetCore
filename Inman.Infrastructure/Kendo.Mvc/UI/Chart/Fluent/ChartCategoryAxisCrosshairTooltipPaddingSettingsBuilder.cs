using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisCrosshairTooltipPaddingSettings
    /// </summary>
    public partial class ChartCategoryAxisCrosshairTooltipPaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisCrosshairTooltipPaddingSettingsBuilder(ChartCategoryAxisCrosshairTooltipPaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisCrosshairTooltipPaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
