using System;
using System.Collections.Generic;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring ChartPaneTitleSettings
    /// </summary>
    public partial class ChartPaneTitleSettingsBuilder<T>
        where T : class 
    {
        /// <summary>
        /// The background color of the title. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Background</param>
        public ChartPaneTitleSettingsBuilder<T> Background(string value)
        {
            Container.Background = value;
            return this;
        }

        /// <summary>
        /// The border of the title.
        /// </summary>
        /// <param name="configurator">The configurator for the border setting.</param>
        public ChartPaneTitleSettingsBuilder<T> Border(Action<ChartPaneTitleBorderSettingsBuilder<T>> configurator)
        {

            Container.Border.Chart = Container.Chart;
            configurator(new ChartPaneTitleBorderSettingsBuilder<T>(Container.Border));

            return this;
        }

        /// <summary>
        /// The text color of the title. Accepts a valid CSS color string, including hex and rgb.
        /// </summary>
        /// <param name="value">The value for Color</param>
        public ChartPaneTitleSettingsBuilder<T> Color(string value)
        {
            Container.Color = value;
            return this;
        }

        /// <summary>
        /// The font style of the title.
        /// </summary>
        /// <param name="value">The value for Font</param>
        public ChartPaneTitleSettingsBuilder<T> Font(string value)
        {
            Container.Font = value;
            return this;
        }

        /// <summary>
        /// The margin of the title. A numeric value will set all margins.
        /// </summary>
        /// <param name="configurator">The configurator for the margin setting.</param>
        public ChartPaneTitleSettingsBuilder<T> Margin(Action<ChartPaneTitleMarginSettingsBuilder<T>> configurator)
        {

            Container.Margin.Chart = Container.Chart;
            configurator(new ChartPaneTitleMarginSettingsBuilder<T>(Container.Margin));

            return this;
        }

        /// <summary>
        /// The position of the title.The supported values are:
        /// </summary>
        /// <param name="value">The value for Position</param>
        public ChartPaneTitleSettingsBuilder<T> Position(string value)
        {
            Container.Position = value;
            return this;
        }

        /// <summary>
        /// The text of the title.
        /// </summary>
        /// <param name="value">The value for Text</param>
        public ChartPaneTitleSettingsBuilder<T> Text(string value)
        {
            Container.Text = value;
            return this;
        }

        /// <summary>
        /// If set to true the chart will display the pane title. By default the pane title is visible.
        /// </summary>
        /// <param name="value">The value for Visible</param>
        public ChartPaneTitleSettingsBuilder<T> Visible(bool value)
        {
            Container.Visible = value;
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the title. The available argument fields are:
        /// </summary>
        /// <param name="handler">The name of the JavaScript function that will be evaluated.</param>
        public ChartPaneTitleSettingsBuilder<T> Visual(string handler)
        {
            Container.Visual = new ClientHandlerDescriptor { HandlerName = handler };
            return this;
        }

        /// <summary>
        /// A function that can be used to create a custom visual for the title. The available argument fields are:
        /// </summary>
        /// <param name="handler">The handler code wrapped in a text tag.</param>
        public ChartPaneTitleSettingsBuilder<T> Visual(Func<object, object> handler)
        {
            Container.Visual = new ClientHandlerDescriptor { TemplateDelegate = handler };
            return this;
        }
    }
}
