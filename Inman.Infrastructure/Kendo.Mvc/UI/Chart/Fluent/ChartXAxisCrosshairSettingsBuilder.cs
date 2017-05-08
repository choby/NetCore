using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisCrosshairSettings
    /// </summary>
    public partial class ChartXAxisCrosshairSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisCrosshairSettingsBuilder(ChartXAxisCrosshairSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisCrosshairSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
