using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisNotesLabelSettings
    /// </summary>
    public partial class ChartCategoryAxisNotesLabelSettingsBuilder<T>
        where T : class 
    {
        public ChartCategoryAxisNotesLabelSettingsBuilder(ChartCategoryAxisNotesLabelSettings<T> container)
        {
            Container = container;
        }

        protected ChartCategoryAxisNotesLabelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
