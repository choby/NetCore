using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListFilterableSettings
    /// </summary>
    public partial class TreeListFilterableSettingsBuilder<T>
        
    {
        public TreeListFilterableSettingsBuilder(TreeListFilterableSettings<T> container)
        {
            Container = container;
        }

        protected TreeListFilterableSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
