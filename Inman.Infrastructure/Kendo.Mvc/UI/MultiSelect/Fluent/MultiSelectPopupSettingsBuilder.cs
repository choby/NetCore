using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MultiSelectPopupSettings
    /// </summary>
    public partial class MultiSelectPopupSettingsBuilder
        
    {
        public MultiSelectPopupSettingsBuilder(MultiSelectPopupSettings container)
        {
            Container = container;
        }

        protected MultiSelectPopupSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
