using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeScaleLineSettings
    /// </summary>
    public partial class LinearGaugeScaleLineSettingsBuilder
        
    {
        public LinearGaugeScaleLineSettingsBuilder(LinearGaugeScaleLineSettings container)
        {
            Container = container;
        }

        protected LinearGaugeScaleLineSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
