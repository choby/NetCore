using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ToolBarItemButton
    /// </summary>
    public partial class ToolBarItemButtonBuilder
        
    {
        public ToolBarItemButtonBuilder(ToolBarItemButton container)
        {
            Container = container;
        }

        protected ToolBarItemButton Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
