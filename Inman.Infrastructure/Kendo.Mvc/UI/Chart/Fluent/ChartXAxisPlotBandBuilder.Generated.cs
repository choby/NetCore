using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartXAxisPlotBand
    /// </summary>
    public partial class ChartXAxisPlotBandBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the plot band.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartXAxisPlotBandBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The start position of the plot band in axis units.
        /// </summary>
        /// <param name="value">The value for From</param>
        public ChartXAxisPlotBandBuilder<T> From(object value)
        {
            Container.From = value;
            return this;
        }

        /// <summary>
        /// The opacity of the plot band.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartXAxisPlotBandBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The end position of the plot band in axis units.
        /// </summary>
        /// <param name="value">The value for To</param>
        public ChartXAxisPlotBandBuilder<T> To(object value)
        {
            Container.To = value;
            return this;
        }

    }
}
