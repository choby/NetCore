using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesNotesLabelSettings
    /// </summary>
    public partial class ChartSeriesNotesLabelSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesNotesLabelSettingsBuilder(ChartSeriesNotesLabelSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesNotesLabelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
