using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisLabelsBorderSettings
    /// </summary>
    public partial class ChartXAxisLabelsBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisLabelsBorderSettingsBuilder(ChartXAxisLabelsBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisLabelsBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
