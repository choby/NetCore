using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesOverlaySettings
    /// </summary>
    public partial class StockChartNavigatorSeriesOverlaySettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The gradient name.Available options:
        /// </summary>
        /// <param name="value">The value for Gradient</param>
        public StockChartNavigatorSeriesOverlaySettingsBuilder<T> Gradient(string value)
        {
            Container.Gradient = value;
            return this;
        }

    }
}
