using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ToolBarItemButton>
    /// </summary>
    public partial class ToolBarItemButtonFactory
        
    {
        public ToolBarItemButtonFactory(List<ToolBarItemButton> container)
        {
            Container = container;
        }

        protected List<ToolBarItemButton> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
