using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<TreeListColumnCommand<T>>
    /// </summary>
    public partial class TreeListColumnCommandFactory<T>
        
    {
        public TreeListColumnCommandFactory(List<TreeListColumnCommand<T>> container)
        {
            Container = container;
        }

        protected List<TreeListColumnCommand<T>> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
