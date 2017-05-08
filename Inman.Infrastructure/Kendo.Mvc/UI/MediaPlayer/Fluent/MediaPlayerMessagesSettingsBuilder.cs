using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MediaPlayerMessagesSettings
    /// </summary>
    public partial class MediaPlayerMessagesSettingsBuilder
        
    {
        public MediaPlayerMessagesSettingsBuilder(MediaPlayerMessagesSettings container)
        {
            Container = container;
        }

        protected MediaPlayerMessagesSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
