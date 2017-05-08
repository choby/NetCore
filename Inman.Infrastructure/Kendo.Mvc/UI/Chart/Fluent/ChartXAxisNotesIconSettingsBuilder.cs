using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisNotesIconSettings
    /// </summary>
    public partial class ChartXAxisNotesIconSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisNotesIconSettingsBuilder(ChartXAxisNotesIconSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisNotesIconSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
