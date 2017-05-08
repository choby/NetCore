using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring PivotGridExcelSettings
    /// </summary>
    public partial class PivotGridExcelSettingsBuilder<T>
        where T : class 
    {
        public PivotGridExcelSettingsBuilder(PivotGridExcelSettings<T> container)
        {
            Container = container;
        }

        protected PivotGridExcelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
