using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring GridExcelSettings
    /// </summary>
    public partial class GridExcelSettingsBuilder<T>
        
    {
        public GridExcelSettingsBuilder(GridExcelSettings<T> container)
        {
            Container = container;
        }

        protected GridExcelSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
