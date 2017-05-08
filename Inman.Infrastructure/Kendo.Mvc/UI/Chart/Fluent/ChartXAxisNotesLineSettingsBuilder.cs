using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisNotesLineSettings
    /// </summary>
    public partial class ChartXAxisNotesLineSettingsBuilder<T>
        where T : class 
    {
        public ChartXAxisNotesLineSettingsBuilder(ChartXAxisNotesLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartXAxisNotesLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
