using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring BarcodeBorderSettings
    /// </summary>
    public partial class BarcodeBorderSettingsBuilder
        
    {
        public BarcodeBorderSettingsBuilder(BarcodeBorderSettings container)
        {
            Container = container;
        }

        protected BarcodeBorderSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
