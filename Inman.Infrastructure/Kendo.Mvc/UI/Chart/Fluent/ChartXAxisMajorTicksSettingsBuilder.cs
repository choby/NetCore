using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisMajorTicksSettings
    /// </summary>
    public partial class ChartXAxisMajorTicksSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisMajorTicksSettingsBuilder(ChartXAxisMajorTicksSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisMajorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
