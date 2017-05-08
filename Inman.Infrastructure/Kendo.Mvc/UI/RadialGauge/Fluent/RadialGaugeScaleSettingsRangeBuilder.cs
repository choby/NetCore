using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeScaleSettingsRange
    /// </summary>
    public partial class RadialGaugeScaleSettingsRangeBuilder
        
    {
        public RadialGaugeScaleSettingsRangeBuilder(RadialGaugeScaleSettingsRange container)
        {
            Container = container;
        }

        protected RadialGaugeScaleSettingsRange Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
