namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred widget rendering mode.
    /// </summary>
    public enum RenderingMode
    {
        /// <summary>
        /// Attempts to render the widget as an inline SVG document.
        /// </summary>
        SVG,
        /// <summary>
        /// Attempts to render the widget as Canvas element.
        /// </summary>
        Canvas,
        /// <summary>
        /// Attempts to render the widget as VML elements.
        /// </summary>
        VML
    }

    internal static class RenderingModeExtensions
    {
        internal static string Serialize(this RenderingMode value)
        {
            switch (value)
            {
                case RenderingMode.SVG:
                    return "svg";
                case RenderingMode.Canvas:
                    return "canvas";
                case RenderingMode.VML:
                    return "vml";
            }

            return value.ToString();
        }
    }
}

