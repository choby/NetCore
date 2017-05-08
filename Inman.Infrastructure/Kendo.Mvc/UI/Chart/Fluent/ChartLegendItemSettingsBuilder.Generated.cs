using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendItemSettings
    /// </summary>
    public partial class ChartLegendItemSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The cursor style of the legend item.
        /// </summary>
        /// <param name="value">The value for Cursor</param>
        public ChartLegendItemSettingsBuilder<T> Cursor(string value)
        {
            Container.Cursor = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the legend items. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartLegendItemSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the legend items. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartLegendItemSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
