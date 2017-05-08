using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorFileBrowserMessagesSettings
    /// </summary>
    public partial class EditorFileBrowserMessagesSettingsBuilder
        
    {
        public EditorFileBrowserMessagesSettingsBuilder(EditorFileBrowserMessagesSettings container)
        {
            Container = container;
        }

        protected EditorFileBrowserMessagesSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
