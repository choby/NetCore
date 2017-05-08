using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesOutliersSettings
    /// </summary>
    public partial class ChartSeriesOutliersSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the series outliers.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartSeriesOutliersSettingsBuilder<T> Background(string value)
        {
            Container.BackgroundHandler = null;
            Container.Background = value;
            return this;
        }
        /// <summary>
        /// The background color of the series outliers.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesOutliersSettingsBuilder<T> BackgroundHandler(string handler)
        {
            Container.Background = null;
            Container.BackgroundHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The background color of the series outliers.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesOutliersSettingsBuilder<T> BackgroundHandler(Func<object, object> handler)
        {
            Container.Background = null;
            Container.BackgroundHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The border of the outliers.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartSeriesOutliersSettingsBuilder<T> Border(Action<ChartSeriesOutliersBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartSeriesOutliersBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The marker size in pixels.
        /// </summary>
        /// <param name="value">The value for Size</param>
        public ChartSeriesOutliersSettingsBuilder<T> Size(double value)
        {
            Container.Size = value;
            return this;
        }

        /// <summary>
        /// The outliers shape.The supported values are:
		/// * "circle" - the marker shape is circle.
		/// * "square" - the marker shape is square.
		/// * "triangle" - the marker shape is triangle.
		/// * "cross" - the marker shape is cross.
        /// </summary>
        /// <param name="value">The value for Type</param>
        public ChartSeriesOutliersSettingsBuilder<T> Type(string value)
        {
            Container.TypeHandler = null;
            Container.Type = value;
            return this;
        }
        /// <summary>
        /// The outliers shape.The supported values are:
		/// * "circle" - the marker shape is circle.
		/// * "square" - the marker shape is square.
		/// * "triangle" - the marker shape is triangle.
		/// * "cross" - the marker shape is cross.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesOutliersSettingsBuilder<T> TypeHandler(string handler)
        {
            Container.Type = null;
            Container.TypeHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The outliers shape.The supported values are:
		/// * "circle" - the marker shape is circle.
		/// * "square" - the marker shape is square.
		/// * "triangle" - the marker shape is triangle.
		/// * "cross" - the marker shape is cross.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesOutliersSettingsBuilder<T> TypeHandler(Func<object, object> handler)
        {
            Container.Type = null;
            Container.TypeHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The rotation angle of the outliers.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public ChartSeriesOutliersSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation = value;
            return this;
        }

    }
}
