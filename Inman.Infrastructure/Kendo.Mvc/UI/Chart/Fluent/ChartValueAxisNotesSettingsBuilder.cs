using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisNotesSettings
    /// </summary>
    public partial class ChartValueAxisNotesSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisNotesSettingsBuilder(ChartValueAxisNotesSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisNotesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
