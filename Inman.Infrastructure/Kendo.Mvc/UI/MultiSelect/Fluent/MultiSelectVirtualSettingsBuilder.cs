using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring MultiSelectVirtualSettings
    /// </summary>
    public partial class MultiSelectVirtualSettingsBuilder
        
    {
        public MultiSelectVirtualSettingsBuilder(MultiSelectVirtualSettings container)
        {
            Container = container;
        }

        protected MultiSelectVirtualSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
