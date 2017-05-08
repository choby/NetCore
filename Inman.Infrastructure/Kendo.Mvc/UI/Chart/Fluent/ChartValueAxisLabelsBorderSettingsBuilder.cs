using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisLabelsBorderSettings
    /// </summary>
    public partial class ChartValueAxisLabelsBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisLabelsBorderSettingsBuilder(ChartValueAxisLabelsBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisLabelsBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
