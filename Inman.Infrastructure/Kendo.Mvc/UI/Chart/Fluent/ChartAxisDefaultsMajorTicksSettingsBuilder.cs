using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsMajorTicksSettings
    /// </summary>
    public partial class ChartAxisDefaultsMajorTicksSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsMajorTicksSettingsBuilder(ChartAxisDefaultsMajorTicksSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsMajorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
