using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetSortSettings
    /// </summary>
    public partial class SpreadsheetSheetSortSettingsBuilder
        
    {
        public SpreadsheetSheetSortSettingsBuilder(SpreadsheetSheetSortSettings container)
        {
            Container = container;
        }

        protected SpreadsheetSheetSortSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
