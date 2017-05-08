using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListColumnFilterableSettings
    /// </summary>
    public partial class TreeListColumnFilterableSettingsBuilder<T>
        
    {
        public TreeListColumnFilterableSettingsBuilder(TreeListColumnFilterableSettings<T> container)
        {
            Container = container;
        }

        protected TreeListColumnFilterableSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
