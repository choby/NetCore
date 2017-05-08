using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisNotesSettings
    /// </summary>
    public partial class ChartXAxisNotesSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisNotesSettingsBuilder(ChartXAxisNotesSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisNotesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
