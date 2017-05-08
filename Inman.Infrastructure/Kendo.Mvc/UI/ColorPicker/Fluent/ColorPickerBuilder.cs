using System;
using System.Collections.Generic;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ColorPicker
    /// </summary>
    public partial class ColorPickerBuilder: WidgetBuilderBase<ColorPicker, ColorPickerBuilder>
        
    {
        public ColorPickerBuilder(ColorPicker component) : base(component)
        {
        }

		/// <summary>
		/// Sets the range of colors that the user can pick from.
		/// </summary>
		/// <param name="palette">A list of colors.</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().ColorPicker()
		///             .Name("ColorPicker")
		///             .Palette(new List&lt;string&gt; { "#ff0000", "#00ff00", "#0000ff" })
		/// %&gt;
		/// </code>
		/// </example>
		public ColorPickerBuilder Palette(params string[] palette)
		{
			Component.PaletteColors = palette;
			Component.Palette = ColorPickerPalette.None;

			return this;
		}

		/// <summary>
		/// Enables or disables the picker.
		/// </summary>
		/// <param name="value">Whether the picker is enabled</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().ColorPicker()
		///             .Name("ColorPicker")
		///             .Enable(false)
		/// %&gt;
		/// </code>
		/// </example>
		public ColorPickerBuilder Enable(bool value)
		{
			Component.Enabled = value;

			return this;
		}

		/// <summary>
		/// Sets the size of the palette tiles
		/// </summary>
		/// <param name="tileSize">The tile size (for square tiles)</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().ColorPalette()
		///             .Name("ColorPalette")
		///             .TileSize(32)
		/// %&gt;
		/// </code>
		/// </example>
		public ColorPickerBuilder TileSize(int tileSize)
		{
			Component.TileSize.Width = tileSize;
			Component.TileSize.Height = tileSize;

			return this;
		}
	}
}

