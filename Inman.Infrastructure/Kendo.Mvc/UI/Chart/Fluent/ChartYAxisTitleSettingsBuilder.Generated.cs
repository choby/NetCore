using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartYAxisTitleSettings
    /// </summary>
    public partial class ChartYAxisTitleSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the title. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartYAxisTitleSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the title.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartYAxisTitleSettingsBuilder<T> Border(Action<ChartYAxisTitleBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartYAxisTitleBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the title. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartYAxisTitleSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font style of the title.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartYAxisTitleSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The margin of the title. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartYAxisTitleSettingsBuilder<T> Margin(Action<ChartYAxisTitleMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartYAxisTitleMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The padding of the title. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartYAxisTitleSettingsBuilder<T> Padding(Action<ChartYAxisTitlePaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartYAxisTitlePaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The rotation angle of the title. By default the title is not rotated.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public ChartYAxisTitleSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation = value;
            return this;
        }

        /// <summary>
        /// The text of the title.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public ChartYAxisTitleSettingsBuilder<T> Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the scatter chart y axis title. By default the scatter chart y axis title is visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartYAxisTitleSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the title. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartYAxisTitleSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the title. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartYAxisTitleSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
        /// <summary>
        /// Specifies the title position.
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartYAxisTitleSettingsBuilder<T> Position(ChartAxisTitlePosition value)
        {
            Container.Position = value;
            return this;
        }

    }
}
