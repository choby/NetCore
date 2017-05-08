using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring LinearGaugeScaleMajorTicksSettings
    /// </summary>
    public partial class LinearGaugeScaleMajorTicksSettingsBuilder
        
    {
        public LinearGaugeScaleMajorTicksSettingsBuilder(LinearGaugeScaleMajorTicksSettings container)
        {
            Container = container;
        }

        protected LinearGaugeScaleMajorTicksSettings Container
        {
            get;
            private set;
        }

        public LinearGaugeScaleMajorTicksSettingsBuilder DashType(ChartDashType dashType)
        {
            Container.DashType = dashType;

            return this;
        }
    }
}
