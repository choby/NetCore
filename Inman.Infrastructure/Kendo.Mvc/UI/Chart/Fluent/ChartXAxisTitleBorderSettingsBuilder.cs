using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisTitleBorderSettings
    /// </summary>
    public partial class ChartXAxisTitleBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisTitleBorderSettingsBuilder(ChartXAxisTitleBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisTitleBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
