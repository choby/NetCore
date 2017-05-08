using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisNotesLabelSettings
    /// </summary>
    public partial class ChartXAxisNotesLabelSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisNotesLabelSettingsBuilder(ChartXAxisNotesLabelSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisNotesLabelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
