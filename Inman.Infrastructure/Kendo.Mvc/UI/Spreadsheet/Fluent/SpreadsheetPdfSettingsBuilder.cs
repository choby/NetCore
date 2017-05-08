using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetPdfSettings
    /// </summary>
    public partial class SpreadsheetPdfSettingsBuilder
        
    {
        public SpreadsheetPdfSettingsBuilder(SpreadsheetPdfSettings container)
        {
            Container = container;
        }

        protected SpreadsheetPdfSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
