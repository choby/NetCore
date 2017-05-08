using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ComboBoxPopupSettings
    /// </summary>
    public partial class ComboBoxPopupSettingsBuilder
        
    {
        public ComboBoxPopupSettingsBuilder(ComboBoxPopupSettings container)
        {
            Container = container;
        }

        protected ComboBoxPopupSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
