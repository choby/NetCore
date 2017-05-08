using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesTooltipBorderSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesTooltipBorderSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the border.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorSeriesTooltipBorderSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The width of the border.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public StockChartNavigatorSeriesTooltipBorderSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
