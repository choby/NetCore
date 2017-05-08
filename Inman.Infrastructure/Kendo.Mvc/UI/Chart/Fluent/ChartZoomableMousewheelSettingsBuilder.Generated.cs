using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartZoomableMousewheelSettings
    /// </summary>
    public partial class ChartZoomableMousewheelSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Specifies an axis that should not be zoomed.
        /// </summary>
        /// <param name="value">The value for Lock</param>
        public ChartZoomableMousewheelSettingsBuilder<T> Lock(ChartAxisLock value)
        {
            Container.Lock = value;
            return this;
        }

    }
}
