using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisMajorTicksSettings
    /// </summary>
    public partial class ChartCategoryAxisMajorTicksSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisMajorTicksSettingsBuilder(ChartCategoryAxisMajorTicksSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisMajorTicksSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
