using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisCrosshairTooltipSettings
    /// </summary>
    public partial class ChartCategoryAxisCrosshairTooltipSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisCrosshairTooltipSettingsBuilder(ChartCategoryAxisCrosshairTooltipSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisCrosshairTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
