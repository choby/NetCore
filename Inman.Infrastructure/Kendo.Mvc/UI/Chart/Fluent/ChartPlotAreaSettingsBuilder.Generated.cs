using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPlotAreaSettings
    /// </summary>
    public partial class ChartPlotAreaSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the chart plot area. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartPlotAreaSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the chart plot area.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartPlotAreaSettingsBuilder<T> Border(Action<ChartPlotAreaBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartPlotAreaBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The margin of the chart plot area. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartPlotAreaSettingsBuilder<T> Margin(Action<ChartPlotAreaMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartPlotAreaMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The background opacity of the chart plot area. By default the background is opaque.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ChartPlotAreaSettingsBuilder<T> Opacity(double value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// The padding of the chart plot area. A numeric value will set all paddings.The default padding for pie, donut, radar and polar charts is proportional of the chart size.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartPlotAreaSettingsBuilder<T> Padding(Action<ChartPlotAreaPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartPlotAreaPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

    }
}
