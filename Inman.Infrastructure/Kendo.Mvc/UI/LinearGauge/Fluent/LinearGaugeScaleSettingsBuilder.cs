using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeScaleSettings
    /// </summary>
    public partial class LinearGaugeScaleSettingsBuilder
        
    {
        public LinearGaugeScaleSettingsBuilder(LinearGaugeScaleSettings container)
        {
            Container = container;
        }

        protected LinearGaugeScaleSettings Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
