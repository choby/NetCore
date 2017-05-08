using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisNotesIconSettings
    /// </summary>
    public partial class ChartYAxisNotesIconSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisNotesIconSettingsBuilder(ChartYAxisNotesIconSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisNotesIconSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
