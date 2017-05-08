using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesConnectorsSettings
    /// </summary>
    public partial class ChartSeriesConnectorsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the connector. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesConnectorsSettingsBuilder<T> Color(string value)
        {
            Container.ColorHandler = null;
            Container.Color = value;
            return this;
        }
        /// <summary>
        /// The color of the connector. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesConnectorsSettingsBuilder<T> ColorHandler(string handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The color of the connector. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesConnectorsSettingsBuilder<T> ColorHandler(Func<object, object> handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The padding between the connector line and the label, and connector line and donut chart.
        /// </summary>
        /// <param name="value">The value for Padding</param>
        public ChartSeriesConnectorsSettingsBuilder<T> Padding(double value)
        {
            Container.Padding = value;
            return this;
        }

        /// <summary>
        /// The width of the connector line.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartSeriesConnectorsSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
