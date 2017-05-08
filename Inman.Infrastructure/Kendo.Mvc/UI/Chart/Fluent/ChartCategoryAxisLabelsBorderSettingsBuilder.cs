using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisLabelsBorderSettings
    /// </summary>
    public partial class ChartCategoryAxisLabelsBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisLabelsBorderSettingsBuilder(ChartCategoryAxisLabelsBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisLabelsBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
