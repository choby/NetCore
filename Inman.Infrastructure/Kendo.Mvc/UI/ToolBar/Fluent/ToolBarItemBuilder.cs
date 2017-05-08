using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ToolBarItem
    /// </summary>
    public partial class ToolBarItemBuilder
        
    {
        public ToolBarItemBuilder(ToolBarItem container)
        {
            Container = container;
        }

        protected ToolBarItem Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
