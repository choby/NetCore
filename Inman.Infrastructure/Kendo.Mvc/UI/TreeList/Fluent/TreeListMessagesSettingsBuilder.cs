using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListMessagesSettings
    /// </summary>
    public partial class TreeListMessagesSettingsBuilder<T>
        
    {
        public TreeListMessagesSettingsBuilder(TreeListMessagesSettings<T> container)
        {
            Container = container;
        }

        protected TreeListMessagesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
