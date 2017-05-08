using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisSelectMousewheelSettings
    /// </summary>
    public partial class ChartCategoryAxisSelectMousewheelSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisSelectMousewheelSettingsBuilder(ChartCategoryAxisSelectMousewheelSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisSelectMousewheelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
