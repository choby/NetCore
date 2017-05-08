using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisNotesLabelBorderSettings
    /// </summary>
    public partial class ChartYAxisNotesLabelBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisNotesLabelBorderSettingsBuilder(ChartYAxisNotesLabelBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisNotesLabelBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
