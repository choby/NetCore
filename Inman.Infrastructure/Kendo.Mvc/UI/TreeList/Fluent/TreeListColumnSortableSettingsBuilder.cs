using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListColumnSortableSettings
    /// </summary>
    public partial class TreeListColumnSortableSettingsBuilder<T>
        
    {
        public TreeListColumnSortableSettingsBuilder(TreeListColumnSortableSettings<T> container)
        {
            Container = container;
        }

        protected TreeListColumnSortableSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
