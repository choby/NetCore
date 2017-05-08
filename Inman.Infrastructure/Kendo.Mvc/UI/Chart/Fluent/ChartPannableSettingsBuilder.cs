using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPannableSettings
    /// </summary>
    public partial class ChartPannableSettingsBuilder<T>
        where T : class 
    {
        public ChartPannableSettingsBuilder(ChartPannableSettings<T> container)
        {
            Container = container;
        }

        protected ChartPannableSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
