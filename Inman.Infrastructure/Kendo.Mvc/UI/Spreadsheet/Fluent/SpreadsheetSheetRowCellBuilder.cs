using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetRowCell
    /// </summary>
    public partial class SpreadsheetSheetRowCellBuilder
        
    {
        public SpreadsheetSheetRowCellBuilder(SpreadsheetSheetRowCell container)
        {
            Container = container;
        }

        protected SpreadsheetSheetRowCell Container
        {
            get;
            private set;
        }
    }
}
