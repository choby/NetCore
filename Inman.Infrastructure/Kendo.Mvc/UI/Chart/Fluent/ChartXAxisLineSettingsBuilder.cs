using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisLineSettings
    /// </summary>
    public partial class ChartXAxisLineSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisLineSettingsBuilder(ChartXAxisLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
