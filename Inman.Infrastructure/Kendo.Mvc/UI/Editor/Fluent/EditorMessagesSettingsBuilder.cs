using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorMessagesSettings
    /// </summary>
    public partial class EditorMessagesSettingsBuilder
        
    {
        public EditorMessagesSettingsBuilder(EditorMessagesSettings container)
        {
            Container = container;
        }

        protected EditorMessagesSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
