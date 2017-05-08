using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesLabelsBorderSettings
    /// </summary>
    public partial class ChartSeriesLabelsBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesLabelsBorderSettingsBuilder(ChartSeriesLabelsBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesLabelsBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
