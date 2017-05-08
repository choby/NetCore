using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RadialGaugeScaleMajorTicksSettings
    /// </summary>
    public partial class RadialGaugeScaleMajorTicksSettingsBuilder : IHideObjectMembers
        
    {
        public RadialGaugeScaleMajorTicksSettingsBuilder(RadialGaugeScaleMajorTicksSettings container)
        {
            Container = container;
        }

        protected RadialGaugeScaleMajorTicksSettings Container
        {
            get;
            private set;
        }

        /// <summary>
        /// Sets the ticks dashType
        /// </summary>
        /// <param name="dashType">The ticks dashType.</param>      
        public RadialGaugeScaleMajorTicksSettingsBuilder DashType(ChartDashType dashType)
        {
            Container.DashType = dashType;
            return this;
        }
    }
}
