using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartSeriesTargetSettings
    /// </summary>
    public partial class ChartSeriesTargetSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The border of the target.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartSeriesTargetSettingsBuilder<T> Border(Action<ChartSeriesTargetBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartSeriesTargetBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The target color.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartSeriesTargetSettingsBuilder<T> Color(string value)
        {
            Container.ColorHandler = null;
            Container.Color = value;
            return this;
        }
        /// <summary>
        /// The target color.
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartSeriesTargetSettingsBuilder<T> ColorHandler(string handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// The target color.
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartSeriesTargetSettingsBuilder<T> ColorHandler(Func<object, object> handler)
        {
            Container.Color = null;
            Container.ColorHandler = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }

        /// <summary>
        /// The target line options.
        /// </summary>
        /// <param name="configurator">The configurator for the line setting.</param>
        public ChartSeriesTargetSettingsBuilder<T> Line(Action<ChartSeriesTargetLineSettingsBuilder<T>> configurator)
        {

            Container.Line.Chart = Container.Chart;
            configurator(new ChartSeriesTargetLineSettingsBuilder<T>(Container.Line));

            return this;
        }

    }
}
