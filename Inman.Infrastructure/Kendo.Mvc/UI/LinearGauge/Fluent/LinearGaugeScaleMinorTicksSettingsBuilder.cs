using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeScaleMinorTicksSettings
    /// </summary>
    public partial class LinearGaugeScaleMinorTicksSettingsBuilder
        
    {
        public LinearGaugeScaleMinorTicksSettingsBuilder(LinearGaugeScaleMinorTicksSettings container)
        {
            Container = container;
        }

        protected LinearGaugeScaleMinorTicksSettings Container
        {
            get;
            private set;
        }

        public LinearGaugeScaleMinorTicksSettingsBuilder DashType(ChartDashType dashType)
        {
            Container.DashType = dashType;

            return this;
        }
    }
}
