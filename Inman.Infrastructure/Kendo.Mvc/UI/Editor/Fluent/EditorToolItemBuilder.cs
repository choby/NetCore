using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring EditorToolItem
    /// </summary>
    public partial class EditorToolItemBuilder
        
    {
        public EditorToolItemBuilder(EditorToolItem container)
        {
            Container = container;
        }

        protected EditorToolItem Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
