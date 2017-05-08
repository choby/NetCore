using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisNotesLineSettings
    /// </summary>
    public partial class ChartCategoryAxisNotesLineSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisNotesLineSettingsBuilder(ChartCategoryAxisNotesLineSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisNotesLineSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
