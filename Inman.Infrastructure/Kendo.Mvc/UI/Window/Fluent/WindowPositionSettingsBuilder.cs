using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring WindowPositionSettings
    /// </summary>
    public partial class WindowPositionSettingsBuilder
        
    {
        public WindowPositionSettingsBuilder(WindowPositionSettings container)
        {
            Container = container;
        }

        protected WindowPositionSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
