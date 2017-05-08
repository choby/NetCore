using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring StockChartNavigatorSelectSettings
    /// </summary>
    public partial class StockChartNavigatorSelectSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The lower boundary of the selected range.
        /// </summary>
        /// <param name="value">The value for From</param>
        public StockChartNavigatorSelectSettingsBuilder<T> From(DateTime value)
        {
            Container.From = value;
            return this;
        }

        /// <summary>
        /// The mousewheel configuration of the selection.If set to false the mousewheel will not update the selection.
        /// </summary>
        /// <param name="configurator">The configurator for the mousewheel setting.</param>
        public StockChartNavigatorSelectSettingsBuilder<T> Mousewheel(Action<StockChartNavigatorSelectMousewheelSettingsBuilder<T>> configurator)
        {
            Container.Mousewheel.Enabled = true;

            Container.Mousewheel.StockChart = Container.StockChart;
            configurator(new StockChartNavigatorSelectMousewheelSettingsBuilder<T>(Container.Mousewheel));

            return this;
        }

        /// <summary>
        /// The mousewheel configuration of the selection.If set to false the mousewheel will not update the selection.
        /// </summary>
        /// <param name="enabled">Enables or disables the mousewheel option.</param>
        public StockChartNavigatorSelectSettingsBuilder<T> Mousewheel(bool enabled)
        {
            Container.Mousewheel.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// The upper boundary of the selected range.
        /// </summary>
        /// <param name="value">The value for To</param>
        public StockChartNavigatorSelectSettingsBuilder<T> To(DateTime value)
        {
            Container.To = value;
            return this;
        }

    }
}
