using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesBorderSettings
    /// </summary>
    public partial class ChartSeriesBorderSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the border. Accepts a valid CSS color string, including hex and rgb. By default it is set to color of the current series.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesBorderSettingsBuilder<T> Color(string value)
        {
            Container.ColorHandler = null;
            Container.Color = value;
            return this;
        }
        /// <summary>
        /// The color of the border. Accepts a valid CSS color string, including hex and rgb. By default it is set to color of the current series.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesBorderSettingsBuilder<T> ColorHandler(string handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The color of the border. Accepts a valid CSS color string, including hex and rgb. By default it is set to color of the current series.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesBorderSettingsBuilder<T> ColorHandler(Func<object, object> handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The dash type of the border.The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartSeriesBorderSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashTypeHandler = null;
            Container.DashType = value;
            return this;
        }
        /// <summary>
        /// The dash type of the border.The following dash types are supported:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesBorderSettingsBuilder<T> DashTypeHandler(string handler)
        {
            Container.DashType = null;
            Container.DashTypeHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The dash type of the border.The following dash types are supported:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesBorderSettingsBuilder<T> DashTypeHandler(Func<object, object> handler)
        {
            Container.DashType = null;
            Container.DashTypeHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The opacity of the border. By default the border is opaque.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartSeriesBorderSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The width of the border in pixels.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartSeriesBorderSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
