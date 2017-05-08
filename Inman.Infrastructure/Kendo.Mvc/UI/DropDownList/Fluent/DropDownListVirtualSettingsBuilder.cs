using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring DropDownListVirtualSettings
    /// </summary>
    public partial class DropDownListVirtualSettingsBuilder
        
    {
        public DropDownListVirtualSettingsBuilder(DropDownListVirtualSettings container)
        {
            Container = container;
        }

        protected DropDownListVirtualSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
