using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisLabelsBorderSettings
    /// </summary>
    public partial class ChartYAxisLabelsBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisLabelsBorderSettingsBuilder(ChartYAxisLabelsBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisLabelsBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
