using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeViewMessagesSettings
    /// </summary>
    public partial class TreeViewMessagesSettingsBuilder
        
    {
        public TreeViewMessagesSettingsBuilder(TreeViewMessagesSettings container)
        {
            Container = container;
        }

        protected TreeViewMessagesSettings Container
        {
            get;
            private set;
        }        
    }
}
