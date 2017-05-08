using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetPdfMarginSettings
    /// </summary>
    public partial class SpreadsheetPdfMarginSettingsBuilder
        
    {
        public SpreadsheetPdfMarginSettingsBuilder(SpreadsheetPdfMarginSettings container)
        {
            Container = container;
        }

        protected SpreadsheetPdfMarginSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
