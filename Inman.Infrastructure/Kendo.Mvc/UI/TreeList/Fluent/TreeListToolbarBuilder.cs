using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListToolbar
    /// </summary>
    public partial class TreeListToolbarBuilder<T>
        
    {
        public TreeListToolbarBuilder(TreeListToolbar<T> container)
        {
            Container = container;
        }

        protected TreeListToolbar<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
