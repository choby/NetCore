using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSelectMousewheelSettings
    /// </summary>
    public partial class StockChartNavigatorSelectMousewheelSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// If set to true will reverse the mouse wheel direction. The normal direction is down for "zoom out", up for "zoom in".
        /// </summary>
        /// <param name="value">The value for Reverse</param>
        public StockChartNavigatorSelectMousewheelSettingsBuilder<T> Reverse(bool value)
        {
            Container.Reverse = value;
            return this;
        }

        /// <summary>
        /// If set to true will reverse the mouse wheel direction. The normal direction is down for "zoom out", up for "zoom in".
        /// </summary>
        public StockChartNavigatorSelectMousewheelSettingsBuilder<T> Reverse()
        {
            Container.Reverse = true;
            return this;
        }

        /// <summary>
        /// The zoom direction.The supported values are:
        /// </summary>
        /// <param name="value">The value for Zoom</param>
        public StockChartNavigatorSelectMousewheelSettingsBuilder<T> Zoom(string value)
        {
            Container.Zoom = value;
            return this;
        }

    }
}
