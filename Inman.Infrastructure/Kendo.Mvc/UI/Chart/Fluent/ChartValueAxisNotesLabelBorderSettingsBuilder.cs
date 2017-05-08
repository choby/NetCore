using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisNotesLabelBorderSettings
    /// </summary>
    public partial class ChartValueAxisNotesLabelBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisNotesLabelBorderSettingsBuilder(ChartValueAxisNotesLabelBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisNotesLabelBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
