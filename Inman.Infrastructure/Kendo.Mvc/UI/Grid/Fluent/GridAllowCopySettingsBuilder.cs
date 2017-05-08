using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridAllowCopySettings
    /// </summary>
    public partial class GridAllowCopySettingsBuilder<T>
        
    {
        public GridAllowCopySettingsBuilder(GridAllowCopySettings<T> container)
        {
            Container = container;
        }

        protected GridAllowCopySettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
