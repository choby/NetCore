using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsTitleSettings
    /// </summary>
    public partial class ChartAxisDefaultsTitleSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsTitleSettingsBuilder(ChartAxisDefaultsTitleSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsTitleSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
