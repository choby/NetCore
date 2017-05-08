using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartCategoryAxisPlotBand
    /// </summary>
    public partial class ChartCategoryAxisPlotBandBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the plot band.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartCategoryAxisPlotBandBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The start position of the plot band in axis units.
        /// </summary>
        /// <param name="value">The value for From</param>
        public ChartCategoryAxisPlotBandBuilder<T> From(object value)
        {
            Container.From = value;
            return this;
        }

        /// <summary>
        /// The opacity of the plot band.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartCategoryAxisPlotBandBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The end position of the plot band in axis units.
        /// </summary>
        /// <param name="value">The value for To</param>
        public ChartCategoryAxisPlotBandBuilder<T> To(object value)
        {
            Container.To = value;
            return this;
        }

    }
}
