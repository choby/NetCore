using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisNotesLabelSettings
    /// </summary>
    public partial class ChartYAxisNotesLabelSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisNotesLabelSettingsBuilder(ChartYAxisNotesLabelSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisNotesLabelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
