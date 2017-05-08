using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartTitleBorderSettings
    /// </summary>
    public partial class ChartTitleBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartTitleBorderSettingsBuilder(ChartTitleBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartTitleBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
