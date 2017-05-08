using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisLineSettings
    /// </summary>
    public partial class ChartValueAxisLineSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisLineSettingsBuilder(ChartValueAxisLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
