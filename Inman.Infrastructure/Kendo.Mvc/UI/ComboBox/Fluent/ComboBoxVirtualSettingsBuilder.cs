using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ComboBoxVirtualSettings
    /// </summary>
    public partial class ComboBoxVirtualSettingsBuilder
        
    {
        public ComboBoxVirtualSettingsBuilder(ComboBoxVirtualSettings container)
        {
            Container = container;
        }

        protected ComboBoxVirtualSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
