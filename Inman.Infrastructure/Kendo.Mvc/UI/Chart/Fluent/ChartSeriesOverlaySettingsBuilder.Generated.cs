using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesOverlaySettings
    /// </summary>
    public partial class ChartSeriesOverlaySettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Specifies the series gradient.
        /// </summary>
        /// <param name="value">The value for Gradient</param>
        public ChartSeriesOverlaySettingsBuilder<T> Gradient(ChartSeriesGradient value)
        {
            Container.Gradient = value;
            return this;
        }

    }
}
