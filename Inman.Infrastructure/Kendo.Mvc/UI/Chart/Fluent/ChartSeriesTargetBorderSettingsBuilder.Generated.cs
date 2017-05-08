using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesTargetBorderSettings
    /// </summary>
    public partial class ChartSeriesTargetBorderSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The color of the border.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesTargetBorderSettingsBuilder<T> Color(string value)
        {
            Container.ColorHandler = null;
            Container.Color = value;
            return this;
        }
        /// <summary>
        /// The color of the border.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesTargetBorderSettingsBuilder<T> ColorHandler(string handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The color of the border.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesTargetBorderSettingsBuilder<T> ColorHandler(Func<object, object> handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The following dash types are supported:
        /// </summary>
        /// <param name="value">The value for DashType</param>
        public ChartSeriesTargetBorderSettingsBuilder<T> DashType(ChartDashType value)
        {
            Container.DashTypeHandler = null;
            Container.DashType = value;
            return this;
        }
        /// <summary>
        /// The following dash types are supported:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesTargetBorderSettingsBuilder<T> DashTypeHandler(string handler)
        {
            Container.DashType = null;
            Container.DashTypeHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The following dash types are supported:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesTargetBorderSettingsBuilder<T> DashTypeHandler(Func<object, object> handler)
        {
            Container.DashType = null;
            Container.DashTypeHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The width of the border in pixels. By default the border width is set to zero which means that the border will not appear.
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartSeriesTargetBorderSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

    }
}
