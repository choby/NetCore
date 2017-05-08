using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisNotesIconBorderSettings
    /// </summary>
    public partial class ChartValueAxisNotesIconBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartValueAxisNotesIconBorderSettingsBuilder(ChartValueAxisNotesIconBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartValueAxisNotesIconBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
