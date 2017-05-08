using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisMinorTicksSettings
    /// </summary>
    public partial class ChartYAxisMinorTicksSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisMinorTicksSettingsBuilder(ChartYAxisMinorTicksSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisMinorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
