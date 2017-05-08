using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ColorPicker
    /// </summary>
    public partial class ColorPickerBuilder
        
    {
        /// <summary>
        /// Specifies whether the widget should display the Apply / Cancel buttons.Applicable only for the HSV selector, when a pallete is not specified.
        /// </summary>
        /// <param name="value">The value for Buttons</param>
        public ColorPickerBuilder Buttons(bool value)
        {
            Container.Buttons = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the widget should display the 'Clear color' button.Applicable only for the HSV selector, when a pallete is not specified.
        /// </summary>
        /// <param name="value">The value for ClearButton</param>
        public ColorPickerBuilder ClearButton(bool value)
        {
            Container.ClearButton = value;
            return this;
        }

        /// <summary>
        /// Specifies whether the widget should display the 'Clear color' button.Applicable only for the HSV selector, when a pallete is not specified.
        /// </summary>
        public ColorPickerBuilder ClearButton()
        {
            Container.ClearButton = true;
            return this;
        }

        /// <summary>
        /// The number of columns to show in the color dropdown when a pallete is specified.
		/// This is automatically initialized for the "basic" and "websafe" palettes.
		/// If you use a custom palette then you can set this to some value that makes sense for your colors.
        /// </summary>
        /// <param name="value">The value for Columns</param>
        public ColorPickerBuilder Columns(double value)
        {
            Container.Columns = value;
            return this;
        }

        /// <summary>
        /// The size of a color cell.
        /// </summary>
        /// <param name="configurator">The configurator for the tilesize setting.</param>
        public ColorPickerBuilder TileSize(Action<ColorPickerTileSizeSettingsBuilder> configurator)
        {

            Container.TileSize.ColorPicker = Container;
            configurator(new ColorPickerTileSizeSettingsBuilder(Container.TileSize));

            return this;
        }

        /// <summary>
        /// Allows localization of the strings that are used in the widget.
        /// </summary>
        /// <param name="configurator">The configurator for the messages setting.</param>
        public ColorPickerBuilder Messages(Action<ColorPickerMessagesSettingsBuilder> configurator)
        {

            Container.Messages.ColorPicker = Container;
            configurator(new ColorPickerMessagesSettingsBuilder(Container.Messages));

            return this;
        }

        /// <summary>
        /// Only for the HSV selector.  If true, the widget will display the opacity slider.
		/// Note that currently in HTML5 the &lt;input type="color"&gt; does not support opacity.
        /// </summary>
        /// <param name="value">The value for Opacity</param>
        public ColorPickerBuilder Opacity(bool value)
        {
            Container.Opacity = value;
            return this;
        }

        /// <summary>
        /// Only for the HSV selector.  If true, the widget will display the opacity slider.
		/// Note that currently in HTML5 the &lt;input type="color"&gt; does not support opacity.
        /// </summary>
        public ColorPickerBuilder Opacity()
        {
            Container.Opacity = true;
            return this;
        }

        /// <summary>
        /// Only applicable for the HSV selector.Displays the color preview element, along with an input field where the end user can paste a color in a CSS-supported notation.
        /// </summary>
        /// <param name="value">The value for Preview</param>
        public ColorPickerBuilder Preview(bool value)
        {
            Container.Preview = value;
            return this;
        }

        /// <summary>
        /// A CSS class name to display an icon in the color picker button.  If
		/// specified, the HTML for the element will look like this:
        /// </summary>
        /// <param name="value">The value for ToolIcon</param>
        public ColorPickerBuilder ToolIcon(string value)
        {
            Container.ToolIcon = value;
            return this;
        }

        /// <summary>
        /// The initially selected color.
		/// Note that when initializing the widget from an &lt;input&gt; element, the initial color will be decided by the field instead.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public ColorPickerBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }

        /// <summary>
        /// Defines the palettes that can be used in the color picker.
        /// </summary>
        /// <param name="value">The value for Palette</param>
        public ColorPickerBuilder Palette(ColorPickerPalette value)
        {
            Container.Palette = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().ColorPicker()
        ///       .Name("ColorPicker")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public ColorPickerBuilder Events(Action<ColorPickerEventBuilder> configurator)
        {
            configurator(new ColorPickerEventBuilder(Container.Events));
            return this;
        }
        
    }
}

