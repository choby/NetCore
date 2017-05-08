using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisCrosshairSettings
    /// </summary>
    public partial class ChartCategoryAxisCrosshairSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisCrosshairSettingsBuilder(ChartCategoryAxisCrosshairSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisCrosshairSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
