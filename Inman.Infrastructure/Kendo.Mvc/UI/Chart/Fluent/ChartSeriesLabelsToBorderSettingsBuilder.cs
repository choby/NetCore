using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsToBorderSettings
    /// </summary>
    public partial class ChartSeriesLabelsToBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsToBorderSettingsBuilder(ChartSeriesLabelsToBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsToBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
