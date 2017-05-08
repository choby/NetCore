using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisCrosshairSettings
    /// </summary>
    public partial class ChartValueAxisCrosshairSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisCrosshairSettingsBuilder(ChartValueAxisCrosshairSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisCrosshairSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
