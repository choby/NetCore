using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ToolBarItem>
    /// </summary>
    public partial class ToolBarItemFactory
        
    {
        public ToolBarItemFactory(List<ToolBarItem> container)
        {
            Container = container;
        }

        protected List<ToolBarItem> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
