using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring List<SpreadsheetSheet>
    /// </summary>
    public partial class SpreadsheetSheetFactory
        
    {
        public SpreadsheetSheetFactory(List<SpreadsheetSheet> container)
        {
            Container = container;
        }

        protected List<SpreadsheetSheet> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
