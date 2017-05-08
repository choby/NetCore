using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<ToolBarItemMenuButton>
    /// </summary>
    public partial class ToolBarItemMenuButtonFactory
        
    {
        public ToolBarItemMenuButtonFactory(List<ToolBarItemMenuButton> container)
        {
            Container = container;
        }

        protected List<ToolBarItemMenuButton> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
