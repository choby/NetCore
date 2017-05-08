using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesMarkersBorderSettings
    /// </summary>
    public partial class ChartSeriesMarkersBorderSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the border. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesMarkersBorderSettingsBuilder<T> Color(string value)
        {
            Container.ColorHandler = null;
            Container.Color = value;
            return this;
        }
        /// <summary>
        /// The color of the border. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesMarkersBorderSettingsBuilder<T> ColorHandler(string handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The color of the border. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesMarkersBorderSettingsBuilder<T> ColorHandler(Func<object, object> handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The width of the border in pixels. By default the border width is set to zero which means that the border will not appear.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartSeriesMarkersBorderSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
