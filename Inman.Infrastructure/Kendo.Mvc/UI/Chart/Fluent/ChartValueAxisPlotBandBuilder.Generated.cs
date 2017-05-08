using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartValueAxisPlotBand
    /// </summary>
    public partial class ChartValueAxisPlotBandBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the plot band.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartValueAxisPlotBandBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The start position of the plot band in axis units.
        /// </summary>
        /// <param name="value">The value for From</param>
        public ChartValueAxisPlotBandBuilder<T> From(object value)
        {
            Container.From = value;
            return this;
        }

        /// <summary>
        /// The opacity of the plot band.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartValueAxisPlotBandBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The end position of the plot band in axis units.
        /// </summary>
        /// <param name="value">The value for To</param>
        public ChartValueAxisPlotBandBuilder<T> To(object value)
        {
            Container.To = value;
            return this;
        }

    }
}
