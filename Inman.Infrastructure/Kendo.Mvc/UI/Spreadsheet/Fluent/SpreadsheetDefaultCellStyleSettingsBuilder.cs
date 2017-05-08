using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetDefaultCellStyleSettings
    /// </summary>
    public partial class SpreadsheetDefaultCellStyleSettingsBuilder
        
    {
        public SpreadsheetDefaultCellStyleSettingsBuilder(SpreadsheetDefaultCellStyleSettings container)
        {
            Container = container;
        }

        protected SpreadsheetDefaultCellStyleSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
