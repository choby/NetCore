using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisNotesLabelSettings
    /// </summary>
    public partial class ChartValueAxisNotesLabelSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisNotesLabelSettingsBuilder(ChartValueAxisNotesLabelSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisNotesLabelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
