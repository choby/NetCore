using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListColumnMenuSettings
    /// </summary>
    public partial class TreeListColumnMenuSettingsBuilder<T>
        
    {
        public TreeListColumnMenuSettingsBuilder(TreeListColumnMenuSettings<T> container)
        {
            Container = container;
        }

        protected TreeListColumnMenuSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
