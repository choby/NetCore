using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<SpreadsheetSheetRowCell>
    /// </summary>
    public partial class SpreadsheetSheetRowCellFactory
        
    {
        public SpreadsheetSheetRowCellFactory(List<SpreadsheetSheetRowCell> container)
        {
            Container = container;
        }

        protected List<SpreadsheetSheetRowCell> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
