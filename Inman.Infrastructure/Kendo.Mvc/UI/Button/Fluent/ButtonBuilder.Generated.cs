using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI Button
    /// </summary>
    public partial class ButtonBuilder
        
    {
        /// <summary>
        /// Indicates whether the Button should be enabled or disabled. By default, it is enabled, unless a disabled="disabled" attribute is detected.
        /// </summary>
        /// <param name="value">The value for Enable</param>
        public ButtonBuilder Enable(bool value)
        {
            Container.Enable = value;
            return this;
        }

        /// <summary>
        /// Defines a name of an existing icon in the Kendo UI theme sprite. The icon will be applied as background image of a span element inside the Button.
		/// The span element can be added automatically by the widget, or an existing element can be used, if it has a k-icon CSS class applied.
		/// For a list of available icon names, please refer to the Icons demo.
        /// </summary>
        /// <param name="value">The value for Icon</param>
        public ButtonBuilder Icon(string value)
        {
            Container.Icon = value;
            return this;
        }

        /// <summary>
        /// Defines a URL, which will be used for an img element inside the Button. The URL can be relative or absolute. In case it is relative, it will be evaluated with relation to the web page URL.The img element can be added automatically by the widget, or an existing element can be used, if it has a k-image CSS class applied.
        /// </summary>
        /// <param name="value">The value for ImageUrl</param>
        public ButtonBuilder ImageUrl(string value)
        {
            Container.ImageUrl = value;
            return this;
        }

        /// <summary>
        /// Defines a CSS class (or multiple classes separated by spaces), which will be used for applying a background image to a span element inside the Button.
		/// In case you want to use an icon from the Kendo UI theme sprite background image, it is easier to use the icon property.The span element can be added automatically by the widget, or an existing element can be used, if it has a k-sprite CSS class applied.
        /// </summary>
        /// <param name="value">The value for SpriteCssClass</param>
        public ButtonBuilder SpriteCssClass(string value)
        {
            Container.SpriteCssClass = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().Button()
        ///       .Name("Button")
        ///       .Events(events => events
        ///           .Click("onClick")
        ///       )
        /// )
        /// </code>
        /// </example>
        public ButtonBuilder Events(Action<ButtonEventBuilder> configurator)
        {
            configurator(new ButtonEventBuilder(Container.Events));
            return this;
        }
        
    }
}

