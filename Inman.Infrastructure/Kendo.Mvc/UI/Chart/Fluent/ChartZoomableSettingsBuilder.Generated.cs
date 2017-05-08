using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartZoomableSettings
    /// </summary>
    public partial class ChartZoomableSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// Specifies if the chart can be zoomed using the mouse wheel.
        /// </summary>
        /// <param name="configurator">The configurator for the mousewheel setting.</param>
        public ChartZoomableSettingsBuilder<T> Mousewheel(Action<ChartZoomableMousewheelSettingsBuilder<T>> configurator)
        {
            Container.Mousewheel.Enabled = true;

            Container.Mousewheel.Chart = Container.Chart;
            configurator(new ChartZoomableMousewheelSettingsBuilder<T>(Container.Mousewheel));

            return this;
        }

        /// <summary>
        /// Specifies if the chart can be zoomed using the mouse wheel.
        /// </summary>
        /// <param name="enabled">Enables or disables the mousewheel option.</param>
        public ChartZoomableSettingsBuilder<T> Mousewheel(bool enabled)
        {
            Container.Mousewheel.Enabled = enabled;
            return this;
        }

        /// <summary>
        /// Specifies if the chart can be zoomed using selection.
        /// </summary>
        /// <param name="configurator">The configurator for the selection setting.</param>
        public ChartZoomableSettingsBuilder<T> Selection(Action<ChartZoomableSelectionSettingsBuilder<T>> configurator)
        {
            Container.Selection.Enabled = true;

            Container.Selection.Chart = Container.Chart;
            configurator(new ChartZoomableSelectionSettingsBuilder<T>(Container.Selection));

            return this;
        }

        /// <summary>
        /// Specifies if the chart can be zoomed using selection.
        /// </summary>
        /// <param name="enabled">Enables or disables the selection option.</param>
        public ChartZoomableSettingsBuilder<T> Selection(bool enabled)
        {
            Container.Selection.Enabled = enabled;
            return this;
        }

    }
}
