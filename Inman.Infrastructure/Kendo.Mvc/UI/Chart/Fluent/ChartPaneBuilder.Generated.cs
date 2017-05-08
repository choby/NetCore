using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPane
    /// </summary>
    public partial class ChartPaneBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the chart pane. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartPaneBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the chart pane.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartPaneBuilder<T> Border(Action<ChartPaneBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartPaneBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// Specifies whether the charts in the pane should be clipped. By default all charts except radar, polar and 100% stacked charts are clipped.
        /// </summary>
        /// <param name="value">The value for Clip</param>
        public ChartPaneBuilder<T> Clip(bool value)
        {
            Container.Clip = value;
            return this;
        }

        /// <summary>
        /// The chart pane height in pixels.
        /// </summary>
        /// <param name="value">The value for Height</param>
        public ChartPaneBuilder<T> Height(double value)
        {
            Container.Height = value;
            return this;
        }

        /// <summary>
        /// The margin of the pane. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartPaneBuilder<T> Margin(Action<ChartPaneMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartPaneMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The unique name of the chart pane.
        /// </summary>
        /// <param name="value">The value for Name</param>
        public ChartPaneBuilder<T> Name(string value)
        {
            Container.Name = value;
            return this;
        }

        /// <summary>
        /// The padding of the pane. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartPaneBuilder<T> Padding(Action<ChartPanePaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartPanePaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The title configuration of the chart pane.
        /// </summary>
        /// <param name="configurator">The configurator for the title setting.</param>
        public ChartPaneBuilder<T> Title(Action<ChartPaneTitleSettingsBuilder<T>> configurator)
        {

            Container.Title.Chart = Container.Chart;
            configurator(new ChartPaneTitleSettingsBuilder<T>(Container.Title));

            return this;
        }

    }
}
