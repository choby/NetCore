using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisCrosshairTooltipBorderSettings
    /// </summary>
    public partial class ChartCategoryAxisCrosshairTooltipBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisCrosshairTooltipBorderSettingsBuilder(ChartCategoryAxisCrosshairTooltipBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisCrosshairTooltipBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
