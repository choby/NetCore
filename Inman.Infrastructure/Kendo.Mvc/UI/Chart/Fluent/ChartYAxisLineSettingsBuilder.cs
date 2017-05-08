using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisLineSettings
    /// </summary>
    public partial class ChartYAxisLineSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisLineSettingsBuilder(ChartYAxisLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
