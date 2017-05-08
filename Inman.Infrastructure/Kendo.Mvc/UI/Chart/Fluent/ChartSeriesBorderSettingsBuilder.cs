using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesBorderSettings
    /// </summary>
    public partial class ChartSeriesBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesBorderSettingsBuilder(ChartSeriesBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
