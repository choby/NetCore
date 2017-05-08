using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisTitleBorderSettings
    /// </summary>
    public partial class ChartValueAxisTitleBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisTitleBorderSettingsBuilder(ChartValueAxisTitleBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisTitleBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
