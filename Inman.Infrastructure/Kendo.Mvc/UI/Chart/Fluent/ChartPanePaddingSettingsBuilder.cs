using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPanePaddingSettings
    /// </summary>
    public partial class ChartPanePaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartPanePaddingSettingsBuilder(ChartPanePaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartPanePaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
