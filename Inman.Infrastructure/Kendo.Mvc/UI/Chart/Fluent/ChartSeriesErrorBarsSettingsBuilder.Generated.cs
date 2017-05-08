using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesErrorBarsSettings
    /// </summary>
    public partial class ChartSeriesErrorBarsSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The error bars value.The following value types are supported:
        /// </summary>
        /// <param name="value">The value for Value</param>
        public ChartSeriesErrorBarsSettingsBuilder<T> Value(string value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the error bars. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesErrorBarsSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the error bars. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesErrorBarsSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// The xAxis error bars value. See the series.errorBars.value option for a list of the supported value types.
        /// </summary>
        /// <param name="value">The value for XValue</param>
        public ChartSeriesErrorBarsSettingsBuilder<T> XValue(string value)
        {
            Container.XValue = value;
            return this;
        }

        /// <summary>
        /// The yAxis error bars value. See the series.errorBars.value option for a list of the supported value types.
        /// </summary>
        /// <param name="value">The value for YValue</param>
        public ChartSeriesErrorBarsSettingsBuilder<T> YValue(string value)
        {
            Container.YValue = value;
            return this;
        }

        /// <summary>
        /// If set to false, the error bars caps will not be displayed. By default the caps are visible.
        /// </summary>
        /// <param name="value">The value for EndCaps</param>
        public ChartSeriesErrorBarsSettingsBuilder<T> EndCaps(bool value)
        {
            Container.EndCaps = value;
            return this;
        }

        /// <summary>
        /// The color of the error bars. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesErrorBarsSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The error bars line options.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartSeriesErrorBarsSettingsBuilder<T> Line(Action<ChartSeriesErrorBarsLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartSeriesErrorBarsLineSettingsBuilder<T>(Container.Line));

            return this;
        }

    }
}
