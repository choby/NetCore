using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring BarcodeTextMarginSettings
    /// </summary>
    public partial class BarcodeTextMarginSettingsBuilder
        
    {
        public BarcodeTextMarginSettingsBuilder(BarcodeTextMarginSettings container)
        {
            Container = container;
        }

        protected BarcodeTextMarginSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
