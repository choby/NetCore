using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSeriesLabelsBorderSettings
    /// </summary>
    public partial class StockChartNavigatorSeriesLabelsBorderSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the border.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public StockChartNavigatorSeriesLabelsBorderSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The dash type of the border.
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public StockChartNavigatorSeriesLabelsBorderSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashType = value;
            return this;
        }

        /// <summary>
        /// The width of the border.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public StockChartNavigatorSeriesLabelsBorderSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
