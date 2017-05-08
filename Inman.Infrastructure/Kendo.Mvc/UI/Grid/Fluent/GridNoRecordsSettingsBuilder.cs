using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridNoRecordsSettings
    /// </summary>
    public partial class GridNoRecordsSettingsBuilder<T>
        where T : class 
    {
        public GridNoRecordsSettingsBuilder(GridNoRecordsSettings<T> container)
        {
            Container = container;
        }

        protected GridNoRecordsSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
