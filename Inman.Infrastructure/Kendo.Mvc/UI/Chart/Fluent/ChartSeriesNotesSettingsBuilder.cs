using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesNotesSettings
    /// </summary>
    public partial class ChartSeriesNotesSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesNotesSettingsBuilder(ChartSeriesNotesSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesNotesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
