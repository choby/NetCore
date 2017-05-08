using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI FlatColorPicker
    /// </summary>
    public partial class FlatColorPickerBuilder
        
    {
        /// <summary>
        /// Specifies whether we should display the opacity slider to allow
		/// selection of transparency.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public FlatColorPickerBuilder Opacity(bool value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// Specifies whether we should display the opacity slider to allow
		/// selection of transparency.
        /// </summary>
        public FlatColorPickerBuilder Opacity()
        {
            Container.Opacity = true;
            return this;
        }

        /// <summary>
        /// Specifies whether the widget should display the Apply / Cancel buttons.
        /// </summary>
        /// <param name="value">The value for Buttons</param>
        public FlatColorPickerBuilder Buttons(bool value)
        {
            Container.Buttons = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the widget should display the Apply / Cancel buttons.
        /// </summary>
        public FlatColorPickerBuilder Buttons()
        {
            Container.Buttons = true;
            return this;
        }

        /// <summary>
        /// Specifies the initially selected color.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public FlatColorPickerBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// Specifies whether we should display the preview bar which displays the
		/// current color and the input field.
        /// </summary>
        /// <param name="value">The value for Preview</param>
        public FlatColorPickerBuilder Preview(bool value)
        {
            Container.Preview = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the UI should be updated while the user is typing in
		/// the input field, whenever a valid color can be parsed.  If you pass
		/// false for this, the widget will update only when ENTER is pressed.
        /// </summary>
        /// <param name="value">The value for Autoupdate</param>
        public FlatColorPickerBuilder Autoupdate(bool value)
        {
            Container.Autoupdate = value;
            return this;
        }

        /// <summary>
        /// Allows customization of "Apply" / "Cancel" labels.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public FlatColorPickerBuilder Messages(Action<FlatColorPickerMessagesSettingsBuilder> configurator)
        {

            Container.Messages.FlatColorPicker = Container;
            configurator(new FlatColorPickerMessagesSettingsBuilder(Container.Messages));

            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().FlatColorPicker()
        ///       .Name("FlatColorPicker")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public FlatColorPickerBuilder Events(Action<FlatColorPickerEventBuilder> configurator)
        {
            configurator(new FlatColorPickerEventBuilder(Container.Events));
            return this;
        }
        
    }
}

