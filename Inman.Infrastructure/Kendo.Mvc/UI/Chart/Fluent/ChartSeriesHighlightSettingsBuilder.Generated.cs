using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesHighlightSettings
    /// </summary>
    public partial class ChartSeriesHighlightSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The border of the highlighted chart series. The color is computed automatically from the base point color.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartSeriesHighlightSettingsBuilder<T> Border(Action<ChartSeriesHighlightBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartSeriesHighlightBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The highlight color. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesHighlightSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The line of the highlighted chart series. The color is computed automatically from the base point color.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartSeriesHighlightSettingsBuilder<T> Line(Action<ChartSeriesHighlightLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartSeriesHighlightLineSettingsBuilder<T>(Container.Line));

            return this;
        }

        /// <summary>
        /// The opacity of the highlighted points.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartSeriesHighlightSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to handle toggling the points highlight. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesHighlightSettingsBuilder<T> Toggle(string handler)
        {
            Container.Toggle = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to handle toggling the points highlight. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesHighlightSettingsBuilder<T> Toggle(Func<object, object> handler)
        {
            Container.Toggle = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// If set to true the chart will highlight the series when the user hovers it with the mouse.
		/// By default chart series highlighting is enabled.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartSeriesHighlightSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to set custom visual for the point highlight.The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesHighlightSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to set custom visual for the point highlight.The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesHighlightSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
