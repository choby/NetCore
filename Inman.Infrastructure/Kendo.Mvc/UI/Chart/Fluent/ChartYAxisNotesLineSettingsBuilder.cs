using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisNotesLineSettings
    /// </summary>
    public partial class ChartYAxisNotesLineSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisNotesLineSettingsBuilder(ChartYAxisNotesLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisNotesLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
