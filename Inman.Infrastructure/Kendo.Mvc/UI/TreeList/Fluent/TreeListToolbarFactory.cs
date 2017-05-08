using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<TreeListToolbar<T>>
    /// </summary>
    public partial class TreeListToolbarFactory<T>
        
    {
        public TreeListToolbarFactory(List<TreeListToolbar<T>> container)
        {
            Container = container;
        }

        protected List<TreeListToolbar<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
