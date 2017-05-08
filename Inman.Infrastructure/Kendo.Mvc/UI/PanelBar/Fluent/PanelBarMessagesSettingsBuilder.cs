using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PanelBarMessagesSettings
    /// </summary>
    public partial class PanelBarMessagesSettingsBuilder
        
    {
        public PanelBarMessagesSettingsBuilder(PanelBarMessagesSettings container)
        {
            Container = container;
        }

        protected PanelBarMessagesSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
