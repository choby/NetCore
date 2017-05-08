using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsTitleBorderSettings
    /// </summary>
    public partial class ChartAxisDefaultsTitleBorderSettingsBuilder<T>
        where T : class 
    {
        public ChartAxisDefaultsTitleBorderSettingsBuilder(ChartAxisDefaultsTitleBorderSettings<T> container)
        {
            Container = container;
        }

        protected ChartAxisDefaultsTitleBorderSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
