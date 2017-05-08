using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPaneBorderSettings
    /// </summary>
    public partial class ChartPaneBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartPaneBorderSettingsBuilder(ChartPaneBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartPaneBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
