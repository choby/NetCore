using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsTitlePaddingSettings
    /// </summary>
    public partial class ChartAxisDefaultsTitlePaddingSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsTitlePaddingSettingsBuilder(ChartAxisDefaultsTitlePaddingSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsTitlePaddingSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
