using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesNotesIconBorderSettings
    /// </summary>
    public partial class ChartSeriesNotesIconBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesNotesIconBorderSettingsBuilder(ChartSeriesNotesIconBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesNotesIconBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
