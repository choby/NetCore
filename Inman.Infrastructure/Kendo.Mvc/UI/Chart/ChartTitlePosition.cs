namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the title position.
    /// </summary>
    public enum ChartTitlePosition
    {
        /// <summary>
        /// The title is positioned at the top
        /// </summary>
        Top,
        /// <summary>
        /// The title is positioned at the bottom
        /// </summary>
        Bottom
    }

    internal static class ChartTitlePositionExtensions
    {
        internal static string Serialize(this ChartTitlePosition value)
        {
            switch (value)
            {
                case ChartTitlePosition.Top:
                    return "top";
                case ChartTitlePosition.Bottom:
                    return "bottom";
            }

            return value.ToString();
        }
    }
}

