using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisNotesIconSettings
    /// </summary>
    public partial class ChartValueAxisNotesIconSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisNotesIconSettingsBuilder(ChartValueAxisNotesIconSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisNotesIconSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
