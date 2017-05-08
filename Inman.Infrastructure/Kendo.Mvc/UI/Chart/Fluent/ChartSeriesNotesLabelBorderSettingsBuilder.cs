using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesNotesLabelBorderSettings
    /// </summary>
    public partial class ChartSeriesNotesLabelBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartSeriesNotesLabelBorderSettingsBuilder(ChartSeriesNotesLabelBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartSeriesNotesLabelBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
