using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetFilterSettings
    /// </summary>
    public partial class SpreadsheetSheetFilterSettingsBuilder
        
    {
        public SpreadsheetSheetFilterSettingsBuilder(SpreadsheetSheetFilterSettings container)
        {
            Container = container;
        }

        protected SpreadsheetSheetFilterSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
