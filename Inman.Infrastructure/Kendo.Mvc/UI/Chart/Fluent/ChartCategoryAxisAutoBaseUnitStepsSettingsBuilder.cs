using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisAutoBaseUnitStepsSettings
    /// </summary>
    public partial class ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisAutoBaseUnitStepsSettingsBuilder(ChartCategoryAxisAutoBaseUnitStepsSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisAutoBaseUnitStepsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
