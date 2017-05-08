using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SortableCursorOffsetSettings
    /// </summary>
    public partial class SortableCursorOffsetSettingsBuilder
        
    {
        public SortableCursorOffsetSettingsBuilder(SortableCursorOffsetSettings container)
        {
            Container = container;
        }

        protected SortableCursorOffsetSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
