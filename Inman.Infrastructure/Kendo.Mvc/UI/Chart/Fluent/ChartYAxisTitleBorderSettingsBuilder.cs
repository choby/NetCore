using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisTitleBorderSettings
    /// </summary>
    public partial class ChartYAxisTitleBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisTitleBorderSettingsBuilder(ChartYAxisTitleBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisTitleBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
