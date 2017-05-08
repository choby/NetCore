using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeScaleMinorTicksSettings
    /// </summary>
    public partial class RadialGaugeScaleMinorTicksSettingsBuilder
        
    {
        public RadialGaugeScaleMinorTicksSettingsBuilder(RadialGaugeScaleMinorTicksSettings container)
        {
            Container = container;
        }

        protected RadialGaugeScaleMinorTicksSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the ticks dashType
        /// </summary>
        /// <param name="dashType">The ticks dashType.</param>       
        public RadialGaugeScaleMinorTicksSettingsBuilder DashType(ChartDashType dashType)
        {
            Container.DashType = dashType;
            return this;
        }
    }
}
