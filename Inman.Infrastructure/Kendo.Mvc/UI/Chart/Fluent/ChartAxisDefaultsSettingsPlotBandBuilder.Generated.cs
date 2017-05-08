using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsSettingsPlotBand
    /// </summary>
    public partial class ChartAxisDefaultsSettingsPlotBandBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the plot band.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartAxisDefaultsSettingsPlotBandBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The start position of the plot band in axis units.
        /// </summary>
        /// <param name="value">The value for From</param>
        public ChartAxisDefaultsSettingsPlotBandBuilder<T> From(double value)
        {
            Container.From = value;
            return this;
        }

        /// <summary>
        /// The opacity of the plot band.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartAxisDefaultsSettingsPlotBandBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The end position of the plot band in axis units.
        /// </summary>
        /// <param name="value">The value for To</param>
        public ChartAxisDefaultsSettingsPlotBandBuilder<T> To(double value)
        {
            Container.To = value;
            return this;
        }

    }
}
