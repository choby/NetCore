using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisNotesLabelBorderSettings
    /// </summary>
    public partial class ChartXAxisNotesLabelBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisNotesLabelBorderSettingsBuilder(ChartXAxisNotesLabelBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisNotesLabelBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
