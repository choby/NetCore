using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring BarcodePaddingSettings
    /// </summary>
    public partial class BarcodePaddingSettingsBuilder
        
    {
        public BarcodePaddingSettingsBuilder(BarcodePaddingSettings container)
        {
            Container = container;
        }

        protected BarcodePaddingSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
