using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartTitleSettings
    /// </summary>
    public partial class ChartTitleSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the title. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartTitleSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the series.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartTitleSettingsBuilder<T> Border(Action<ChartTitleBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartTitleBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the title. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartTitleSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font of the title.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartTitleSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The margin of the title. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartTitleSettingsBuilder<T> Margin(Action<ChartTitleMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartTitleMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The padding of the title. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartTitleSettingsBuilder<T> Padding(Action<ChartTitlePaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartTitlePaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The text of the chart title. You can also set the text directly for a title with default options.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public ChartTitleSettingsBuilder<T> Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the title. By default the title will be displayed.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartTitleSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// Specifies the text alignment.
        /// </summary>
        /// <param name="value">The value for Align</param>
        public ChartTitleSettingsBuilder<T> Align(ChartTextAlignment value)
        {
            Container.Align = value;
            return this;
        }

        /// <summary>
        /// Specifies the title position.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartTitleSettingsBuilder<T> Position(ChartTitlePosition value)
        {
            Container.Position = value;
            return this;
        }

    }
}
