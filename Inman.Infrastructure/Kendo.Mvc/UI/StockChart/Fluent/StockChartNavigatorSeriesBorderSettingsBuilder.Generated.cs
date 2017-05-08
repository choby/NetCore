using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesBorderSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesBorderSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the border.  It defaults to the color of the current series.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorSeriesBorderSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the border.
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public StockChartNavigatorSeriesBorderSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The width of the border.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public StockChartNavigatorSeriesBorderSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
