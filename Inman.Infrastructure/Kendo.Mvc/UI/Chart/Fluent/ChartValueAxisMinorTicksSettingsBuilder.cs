using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisMinorTicksSettings
    /// </summary>
    public partial class ChartValueAxisMinorTicksSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisMinorTicksSettingsBuilder(ChartValueAxisMinorTicksSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisMinorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
