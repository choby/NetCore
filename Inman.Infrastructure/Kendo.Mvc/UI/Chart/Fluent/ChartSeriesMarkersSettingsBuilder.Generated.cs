using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesMarkersSettings
    /// </summary>
    public partial class ChartSeriesMarkersSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the series markers.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartSeriesMarkersSettingsBuilder<T> Background(string value)
        {
            Container.BackgroundHandler = null;
            Container.Background = value;
            return this;
        }
        /// <summary>
        /// The background color of the series markers.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesMarkersSettingsBuilder<T> BackgroundHandler(string handler)
        {
            Container.Background = null;
            Container.BackgroundHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The background color of the series markers.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesMarkersSettingsBuilder<T> BackgroundHandler(Func<object, object> handler)
        {
            Container.Background = null;
            Container.BackgroundHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The border of the markers.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartSeriesMarkersSettingsBuilder<T> Border(Action<ChartSeriesMarkersBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartSeriesMarkersBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The marker size in pixels.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public ChartSeriesMarkersSettingsBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the series markers. By default chart series markers are displayed.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartSeriesMarkersSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the markers. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesMarkersSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the markers. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesMarkersSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// The rotation angle of the markers.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public ChartSeriesMarkersSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation = value;
            return this;
        }

        /// <summary>
        /// Specifies the shape of the marker.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public ChartSeriesMarkersSettingsBuilder<T> Type(ChartMarkerShape value)
        {
            Container.TypeHandler = null;
            Container.Type = value;
            return this;
        }
        /// <summary>
        /// Specifies the shape of the marker.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesMarkersSettingsBuilder<T> TypeHandler(string handler)
        {
            Container.Type = null;
            Container.TypeHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// Specifies the shape of the marker.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesMarkersSettingsBuilder<T> TypeHandler(Func<object, object> handler)
        {
            Container.Type = null;
            Container.TypeHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

    }
}
