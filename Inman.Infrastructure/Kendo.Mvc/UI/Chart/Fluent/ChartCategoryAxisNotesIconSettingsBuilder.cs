using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisNotesIconSettings
    /// </summary>
    public partial class ChartCategoryAxisNotesIconSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisNotesIconSettingsBuilder(ChartCategoryAxisNotesIconSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisNotesIconSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
