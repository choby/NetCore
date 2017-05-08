using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring RangeSliderTooltipSettings
    /// </summary>
    public partial class RangeSliderTooltipSettingsBuilder<T>
        where T : struct, IComparable 
    {
        public RangeSliderTooltipSettingsBuilder(RangeSliderTooltipSettings<T> container)
        {
            Container = container;
        }

        protected RangeSliderTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
