using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisNotesSettings
    /// </summary>
    public partial class ChartYAxisNotesSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisNotesSettingsBuilder(ChartYAxisNotesSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisNotesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
