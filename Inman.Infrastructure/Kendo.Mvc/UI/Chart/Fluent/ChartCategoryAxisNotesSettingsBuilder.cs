using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisNotesSettings
    /// </summary>
    public partial class ChartCategoryAxisNotesSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisNotesSettingsBuilder(ChartCategoryAxisNotesSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisNotesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
