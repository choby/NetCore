using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SpreadsheetToolbarSettings
    /// </summary>
    public partial class SpreadsheetToolbarSettingsBuilder
        
    {
        public SpreadsheetToolbarSettingsBuilder(SpreadsheetToolbarSettings container)
        {
            Container = container;
        }

        protected SpreadsheetToolbarSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
