using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring DialogMessagesSettings
    /// </summary>
    public partial class DialogMessagesSettingsBuilder
        
    {
        public DialogMessagesSettingsBuilder(DialogMessagesSettings container)
        {
            Container = container;
        }

        protected DialogMessagesSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
