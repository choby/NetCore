using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PivotConfiguratorSortableSettings
    /// </summary>
    public partial class PivotConfiguratorSortableSettingsBuilder
        
    {
        public PivotConfiguratorSortableSettingsBuilder(PivotConfiguratorSortableSettings container)
        {
            Container = container;
        }

        protected PivotConfiguratorSortableSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
