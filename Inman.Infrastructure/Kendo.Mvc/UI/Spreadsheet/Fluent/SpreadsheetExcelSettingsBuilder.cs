using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetExcelSettings
    /// </summary>
    public partial class SpreadsheetExcelSettingsBuilder
        
    {
        public SpreadsheetExcelSettingsBuilder(SpreadsheetExcelSettings container)
        {
            Container = container;
        }

        protected SpreadsheetExcelSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
