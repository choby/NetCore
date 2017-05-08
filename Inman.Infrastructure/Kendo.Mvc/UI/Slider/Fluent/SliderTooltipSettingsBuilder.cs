using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring SliderTooltipSettings
    /// </summary>
    public partial class SliderTooltipSettingsBuilder<T>
        where T : struct, IComparable
    {
        public SliderTooltipSettingsBuilder(SliderTooltipSettings<T> container)
        {
            Container = container;
        }

        protected SliderTooltipSettings<T> Container
        {
            get;
            private set;
        }

        // Place custom settings here
    }
}
