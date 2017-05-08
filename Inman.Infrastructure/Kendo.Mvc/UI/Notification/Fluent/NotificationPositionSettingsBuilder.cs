using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring NotificationPositionSettings
    /// </summary>
    public partial class NotificationPositionSettingsBuilder
        
    {
        public NotificationPositionSettingsBuilder(NotificationPositionSettings container)
        {
            Container = container;
        }

        protected NotificationPositionSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
