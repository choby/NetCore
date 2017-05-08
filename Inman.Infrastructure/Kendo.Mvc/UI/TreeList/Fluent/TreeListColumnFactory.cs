using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<TreeListColumn<T>>
    /// </summary>
    public partial class TreeListColumnFactory<T>
        
    {
        public TreeListColumnFactory(List<TreeListColumn<T>> container)
        {
            Container = container;
        }

        protected List<TreeListColumn<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
