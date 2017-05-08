using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetRow
    /// </summary>
    public partial class SpreadsheetSheetRowBuilder
        
    {
        public SpreadsheetSheetRowBuilder(SpreadsheetSheetRow container)
        {
            Container = container;
        }

        protected SpreadsheetSheetRow Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
