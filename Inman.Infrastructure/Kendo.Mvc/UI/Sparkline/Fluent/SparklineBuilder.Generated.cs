using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Sparkline
    /// </summary>
    public partial class SparklineBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The width to allocate for each data point.
        /// </summary>
        /// <param name="value">The value for PointWidth</param>
        public SparklineBuilder<T> PointWidth(double value)
        {
            Container.PointWidth = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Sparkline()
        ///       .Name("Sparkline")
        ///       .Events(events => events
        ///           .AxisLabelClick("onAxisLabelClick")
        ///       )
        /// )
        /// </code>
        /// </example>
        public SparklineBuilder<T> Events(Action<SparklineEventBuilder> configurator)
        {
            configurator(new SparklineEventBuilder(Container.Events));
            return this;
        }
        
    }
}

