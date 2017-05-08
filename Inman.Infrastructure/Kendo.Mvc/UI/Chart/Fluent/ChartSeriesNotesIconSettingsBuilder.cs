using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesNotesIconSettings
    /// </summary>
    public partial class ChartSeriesNotesIconSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesNotesIconSettingsBuilder(ChartSeriesNotesIconSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesNotesIconSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
