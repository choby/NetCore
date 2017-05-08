using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisMajorTicksSettings
    /// </summary>
    public partial class ChartYAxisMajorTicksSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisMajorTicksSettingsBuilder(ChartYAxisMajorTicksSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisMajorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
