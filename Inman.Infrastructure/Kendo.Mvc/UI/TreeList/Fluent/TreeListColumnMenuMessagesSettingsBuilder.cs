using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListColumnMenuMessagesSettings
    /// </summary>
    public partial class TreeListColumnMenuMessagesSettingsBuilder<T>
        
    {
        public TreeListColumnMenuMessagesSettingsBuilder(TreeListColumnMenuMessagesSettings<T> container)
        {
            Container = container;
        }

        protected TreeListColumnMenuMessagesSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
