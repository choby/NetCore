using System;
using Kendo.Mvc.Extensions;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ColorPalette
    /// </summary>
    public partial class ColorPaletteBuilder
        
    {
        /// <summary>
        /// The number of columns to display.  When you use the "websafe" palette, this will automatically default to 18.
        /// </summary>
        /// <param name="value">The value for Columns</param>
        public ColorPaletteBuilder Columns(int value)
        {
            Container.Columns = value;
            return this;
        }

        /// <summary>
        /// The size of a color cell.
        /// </summary>
        /// <param name="configurator">The configurator for the tilesize setting.</param>
        public ColorPaletteBuilder TileSize(Action<ColorPaletteTileSizeSettingsBuilder> configurator)
        {

            Container.TileSize.ColorPalette = Container;
            configurator(new ColorPaletteTileSizeSettingsBuilder(Container.TileSize));

            return this;
        }

        /// <summary>
        /// Specifies the initially selected color.
        /// </summary>
        /// <param name="value">The value for Value</param>
        public ColorPaletteBuilder Value(string value)
        {
            Container.Value = value;
            return this;
        }


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        /// @(Html.Kendo().ColorPalette()
        ///       .Name("ColorPalette")
        ///       .Events(events => events
        ///           .Change("onChange")
        ///       )
        /// )
        /// </code>
        /// </example>
        public ColorPaletteBuilder Events(Action<ColorPaletteEventBuilder> configurator)
        {
            configurator(new ColorPaletteEventBuilder(Container.Events));
            return this;
        }
        
    }
}

