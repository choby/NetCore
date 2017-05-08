using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartZoomableSelectionSettings
    /// </summary>
    public partial class ChartZoomableSelectionSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Specifies a keyboard key that should be pressed to activate the selection.
        /// </summary>
        /// <param name="value">The value for Key</param>
        public ChartZoomableSelectionSettingsBuilder<T> Key(ChartActivationKey value)
        {
            Container.Key = value;
            return this;
        }

        /// <summary>
        /// Specifies an axis that should not be zoomed.
        /// </summary>
        /// <param name="value">The value for Lock</param>
        public ChartZoomableSelectionSettingsBuilder<T> Lock(ChartAxisLock value)
        {
            Container.Lock = value;
            return this;
        }

    }
}
