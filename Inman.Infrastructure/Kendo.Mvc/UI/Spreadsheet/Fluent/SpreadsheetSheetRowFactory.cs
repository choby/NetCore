using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<SpreadsheetSheetRow>
    /// </summary>
    public partial class SpreadsheetSheetRowFactory
        
    {
        public SpreadsheetSheetRowFactory(List<SpreadsheetSheetRow> container)
        {
            Container = container;
        }

        protected List<SpreadsheetSheetRow> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
