using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisMajorTicksSettings
    /// </summary>
    public partial class ChartValueAxisMajorTicksSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisMajorTicksSettingsBuilder(ChartValueAxisMajorTicksSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisMajorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
