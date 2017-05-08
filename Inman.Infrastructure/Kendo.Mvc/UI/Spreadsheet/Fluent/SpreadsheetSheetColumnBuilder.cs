using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetSheetColumn
    /// </summary>
    public partial class SpreadsheetSheetColumnBuilder
        
    {
        public SpreadsheetSheetColumnBuilder(SpreadsheetSheetColumn container)
        {
            Container = container;
        }

        protected SpreadsheetSheetColumn Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
