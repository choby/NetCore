namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Defines the palettes that can be used in the color picker.
    /// </summary>
    public enum ColorPickerPalette
    {
        /// <summary>
        /// Do not use a palette (allow selection of arbitrary colors)
        /// </summary>
        None,
        /// <summary>
        /// Use a palette of basic colors
        /// </summary>
        Basic,
        /// <summary>
        /// Use a palette of web-safe colors
        /// </summary>
        WebSafe
    }

    internal static class ColorPickerPaletteExtensions
    {
        internal static string Serialize(this ColorPickerPalette value)
        {
            switch (value)
            {
                case ColorPickerPalette.None:
                    return "none";
                case ColorPickerPalette.Basic:
                    return "basic";
                case ColorPickerPalette.WebSafe:
                    return "websafe";
            }

            return value.ToString();
        }
    }
}

