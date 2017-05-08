using System;

namespace Kendo.Mvc.UI.Fluent
{
    /// <summary>
    /// Defines the fluent API for configuring the Kendo UI ColorPalette
    /// </summary>
    public partial class ColorPaletteBuilder: WidgetBuilderBase<ColorPalette, ColorPaletteBuilder>
        
    {
        public ColorPaletteBuilder(ColorPalette component) : base(component)
        {
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
		public ColorPaletteBuilder TileSize(double tileSize)
		{
			Component.TileSize.Width = tileSize;
			Component.TileSize.Height = tileSize;

			return this;
		}

		/// <summary>
		/// Sets the range of colors that the user can pick from.
		/// </summary>
		/// <param name="palette">A list of colors.</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().ColorPalette()
		///             .Name("ColorPalette")
		///             .Palette(new List&lt;string&gt; { "#ff0000", "#00ff00", "#0000ff" })
		/// %&gt;
		/// </code>
		/// </example>
		public ColorPaletteBuilder Palette(params string[] palette)
		{
			Component.PaletteColors = palette;
			Component.Palette = ColorPickerPalette.None;

			return this;
		}

		/// <summary>
		/// Sets the range of colors that the user can pick from.
		/// </summary>
		/// <param name="palette">One of the preset palettes of colors</param>
		/// <example>
		/// <code lang="CS">
		///  &lt;%= Html.Kendo().ColorPalette()
		///             .Name("ColorPalette")
		///             .Palette(ColorPickerPalette.WebSafe)
		/// %&gt;
		/// </code>
		/// </example>
		public ColorPaletteBuilder Palette(ColorPickerPalette palette)
		{
			Component.PaletteColors = null;
			Component.Palette = palette;

			return this;
		}
	}
}

