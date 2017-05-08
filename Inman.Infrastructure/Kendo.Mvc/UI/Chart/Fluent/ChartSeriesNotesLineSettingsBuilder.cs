using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesNotesLineSettings
    /// </summary>
    public partial class ChartSeriesNotesLineSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesNotesLineSettingsBuilder(ChartSeriesNotesLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesNotesLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
