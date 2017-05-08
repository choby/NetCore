using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring AutoCompleteVirtualSettings
    /// </summary>
    public partial class AutoCompleteVirtualSettingsBuilder
        
    {
        public AutoCompleteVirtualSettingsBuilder(AutoCompleteVirtualSettings container)
        {
            Container = container;
        }

        protected AutoCompleteVirtualSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
