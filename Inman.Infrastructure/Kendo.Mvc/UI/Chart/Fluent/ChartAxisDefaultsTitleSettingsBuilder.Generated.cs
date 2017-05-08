using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartAxisDefaultsTitleSettings
    /// </summary>
    public partial class ChartAxisDefaultsTitleSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the title. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the title.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Border(Action<ChartAxisDefaultsTitleBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsTitleBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the title. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font style of the title.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The margin of the title. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Margin(Action<ChartAxisDefaultsTitleMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsTitleMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The padding of the title. A numeric value will set all paddings.
        /// </summary>
        /// <param name="configurator">The configurator for the padding setting.</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Padding(Action<ChartAxisDefaultsTitlePaddingSettingsBuilder<T>> configurator)
        {

            Container.Padding.Chart = Container.Chart;
            configurator(new ChartAxisDefaultsTitlePaddingSettingsBuilder<T>(Container.Padding));

            return this;
        }

        /// <summary>
        /// The position of the title.The supported values are:
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Position(string value)
        {
            Container.Position = value;
            return this;
        }

        /// <summary>
        /// The rotation angle of the title. By default the title is not rotated.
        /// </summary>
        /// <param name="value">The value for Rotation</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Rotation(double value)
        {
            Container.Rotation = value;
            return this;
        }

        /// <summary>
        /// The text of the title.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the axis title. By default the axis title is visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the title. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the title. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartAxisDefaultsTitleSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
