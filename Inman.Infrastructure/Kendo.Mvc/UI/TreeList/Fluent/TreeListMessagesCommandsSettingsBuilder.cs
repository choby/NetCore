using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListMessagesCommandsSettings
    /// </summary>
    public partial class TreeListMessagesCommandsSettingsBuilder<T>
        
    {
        public TreeListMessagesCommandsSettingsBuilder(TreeListMessagesCommandsSettings<T> container)
        {
            Container = container;
        }

        protected TreeListMessagesCommandsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
