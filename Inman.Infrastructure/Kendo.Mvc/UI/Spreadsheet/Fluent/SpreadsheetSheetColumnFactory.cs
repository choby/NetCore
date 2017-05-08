using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<SpreadsheetSheetColumn>
    /// </summary>
    public partial class SpreadsheetSheetColumnFactory
        
    {
        public SpreadsheetSheetColumnFactory(List<SpreadsheetSheetColumn> container)
        {
            Container = container;
        }

        protected List<SpreadsheetSheetColumn> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
