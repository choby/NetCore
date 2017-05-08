using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartLegendSettings
    /// </summary>
    public partial class ChartLegendSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the legend. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartLegendSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the legend.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartLegendSettingsBuilder<T> Border(Action<ChartLegendBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartLegendBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The legend height when the legend.orientation is set to "vertical".
        /// </summary>
        /// <param name="value">The value for Height</param>
        public ChartLegendSettingsBuilder<T> Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The chart inactive legend items configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the inactiveitems setting.</param>
        public ChartLegendSettingsBuilder<T> InactiveItems(Action<ChartLegendInactiveItemsSettingsBuilder<T>> configurator)
        {

            Container.InactiveItems.Chart = Container.Chart;
            configurator(new ChartLegendInactiveItemsSettingsBuilder<T>(Container.InactiveItems));

            return this;
        }

        /// <summary>
        /// The chart legend item configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the item setting.</param>
        public ChartLegendSettingsBuilder<T> Item(Action<ChartLegendItemSettingsBuilder<T>> configurator)
        {

            Container.Item.Chart = Container.Chart;
            configurator(new ChartLegendItemSettingsBuilder<T>(Container.Item));

            return this;
        }

        /// <summary>
        /// The chart legend label configuration.
        /// </summary>
        /// <param name="configurator">The configurator for the labels setting.</param>
        public ChartLegendSettingsBuilder<T> Labels(Action<ChartLegendLabelsSettingsBuilder<T>> configurator)
        {

            Container.Labels.Chart = Container.Chart;
            configurator(new ChartLegendLabelsSettingsBuilder<T>(Container.Labels));

            return this;
        }

        /// <summary>
        /// The margin of the chart legend. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartLegendSettingsBuilder<T> Margin(Action<ChartLegendMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartLegendMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The X offset of the chart legend. The offset is relative to the default position of the legend.
		/// For instance, a value of 20 will move the legend 20 pixels to the right of its initial position.
		/// A negative value will move the legend to the left of its current position.
        /// </summary>
        /// <param name="value">The value for OffsetX</param>
        public ChartLegendSettingsBuilder<T> OffsetX(double value)
        {
            Container.OffsetX = value;
            return this;
        }

        /// <summary>
        /// The Y offset of the chart legend.  The offset is relative to the current position of the legend.
		/// For instance, a value of 20 will move the legend 20 pixels down from its initial position.
		/// A negative value will move the legend upwards from its current position.
        /// </summary>
        /// <param name="value">The value for OffsetY</param>
        public ChartLegendSettingsBuilder<T> OffsetY(double value)
        {
            Container.OffsetY = value;
            return this;
        }

        /// <summary>
        /// The padding of the chart legend. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartLegendSettingsBuilder<T> Padding(Action<ChartLegendPaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartLegendPaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// If set to true the legend items will be reversed.Available in versions 2013.3.1306 and later.
        /// </summary>
        /// <param name="value">The value for Reverse</param>
        public ChartLegendSettingsBuilder<T> Reverse(bool value)
        {
            Container.Reverse = value;
            return this;
        }

        /// <summary>
        /// If set to true the legend items will be reversed.Available in versions 2013.3.1306 and later.
        /// </summary>
        public ChartLegendSettingsBuilder<T> Reverse()
        {
            Container.Reverse = true;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the legend. By default the chart legend is visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartLegendSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// The legend width when the legend.orientation is set to "horizontal".
        /// </summary>
        /// <param name="value">The value for Width</param>
        public ChartLegendSettingsBuilder<T> Width(double value)
        {
            Container.Width = value;
            return this;
        }

        /// <summary>
        /// Specifies the legend align.
        /// </summary>
        /// <param name="value">The value for Align</param>
        public ChartLegendSettingsBuilder<T> Align(ChartLegendAlign value)
        {
            Container.Align = value;
            return this;
        }

        /// <summary>
        /// Specifies the legend orientation.
        /// </summary>
        /// <param name="value">The value for Orientation</param>
        public ChartLegendSettingsBuilder<T> Orientation(ChartLegendOrientation value)
        {
            Container.Orientation = value;
            return this;
        }

        /// <summary>
        /// Specifies the legend position.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartLegendSettingsBuilder<T> Position(ChartLegendPosition value)
        {
            Container.Position = value;
            return this;
        }

    }
}
