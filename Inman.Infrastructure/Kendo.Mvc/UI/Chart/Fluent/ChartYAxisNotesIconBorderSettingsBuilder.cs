using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisNotesIconBorderSettings
    /// </summary>
    public partial class ChartYAxisNotesIconBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartYAxisNotesIconBorderSettingsBuilder(ChartYAxisNotesIconBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartYAxisNotesIconBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
