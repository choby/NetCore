using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PivotGridSortableSettings
    /// </summary>
    public partial class PivotGridSortableSettingsBuilder<T>
        where T : class 
    {
        public PivotGridSortableSettingsBuilder(PivotGridSortableSettings<T> container)
        {
            Container = container;
        }

        protected PivotGridSortableSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
