using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisNotesLineSettings
    /// </summary>
    public partial class ChartValueAxisNotesLineSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisNotesLineSettingsBuilder(ChartValueAxisNotesLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisNotesLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
