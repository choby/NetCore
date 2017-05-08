using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPaneTitleBorderSettings
    /// </summary>
    public partial class ChartPaneTitleBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartPaneTitleBorderSettingsBuilder(ChartPaneTitleBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartPaneTitleBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
