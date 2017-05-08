using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisCrosshairSettings
    /// </summary>
    public partial class ChartYAxisCrosshairSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisCrosshairSettingsBuilder(ChartYAxisCrosshairSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisCrosshairSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
