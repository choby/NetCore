using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisMinorGridLinesSettings
    /// </summary>
    public partial class ChartCategoryAxisMinorGridLinesSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisMinorGridLinesSettingsBuilder(ChartCategoryAxisMinorGridLinesSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisMinorGridLinesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
