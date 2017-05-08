using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListFilterableMessagesSettings
    /// </summary>
    public partial class TreeListFilterableMessagesSettingsBuilder<T>
        
    {
        public TreeListFilterableMessagesSettingsBuilder(TreeListFilterableMessagesSettings<T> container)
        {
            Container = container;
        }

        protected TreeListFilterableMessagesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
