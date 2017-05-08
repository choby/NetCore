using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisMinorTicksSettings
    /// </summary>
    public partial class ChartCategoryAxisMinorTicksSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisMinorTicksSettingsBuilder(ChartCategoryAxisMinorTicksSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisMinorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
