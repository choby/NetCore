using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring TreeListColumnCommand
    /// </summary>
    public partial class TreeListColumnCommandBuilder<T>
        
    {
        public TreeListColumnCommandBuilder(TreeListColumnCommand<T> container)
        {
            Container = container;
        }

        protected TreeListColumnCommand<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
