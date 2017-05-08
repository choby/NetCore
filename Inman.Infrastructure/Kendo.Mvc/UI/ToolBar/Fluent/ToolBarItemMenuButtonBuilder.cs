using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ToolBarItemMenuButton
    /// </summary>
    public partial class ToolBarItemMenuButtonBuilder
        
    {
        public ToolBarItemMenuButtonBuilder(ToolBarItemMenuButton container)
        {
            Container = container;
        }

        protected ToolBarItemMenuButton Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
