using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisMinorTicksSettings
    /// </summary>
    public partial class ChartXAxisMinorTicksSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisMinorTicksSettingsBuilder(ChartXAxisMinorTicksSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisMinorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
