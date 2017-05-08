using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<SpreadsheetSheetSortSettingsColumn>
    /// </summary>
    public partial class SpreadsheetSheetSortSettingsColumnFactory
        
    {
        public SpreadsheetSheetSortSettingsColumnFactory(List<SpreadsheetSheetSortSettingsColumn> container)
        {
            Container = container;
        }

        protected List<SpreadsheetSheetSortSettingsColumn> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
