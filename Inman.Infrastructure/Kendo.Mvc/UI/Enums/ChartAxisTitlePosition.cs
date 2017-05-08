namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the position of the title.
    /// </summary>
    public enum ChartAxisTitlePosition
    {
        /// <summary>
        /// The title is positioned at the bottom.
        /// </summary>
        Bottom,
        /// <summary>
        /// The title is positioned in the center.
        /// </summary>
        Center,
        /// <summary>
        /// The title is positioned on the left.
        /// </summary>
        Left,
        /// <summary>
        /// The title is positioned on the right.
        /// </summary>
        Right,
        /// <summary>
        /// The title is positioned at the top.
        /// </summary>
        Top
    }

    internal static class ChartAxisTitlePositionExtensions
    {
        internal static string Serialize(this ChartAxisTitlePosition value)
        {
            switch (value)
            {
                case ChartAxisTitlePosition.Bottom:
                    return "bottom";
                case ChartAxisTitlePosition.Center:
                    return "center";
                case ChartAxisTitlePosition.Left:
                    return "left";
                case ChartAxisTitlePosition.Right:
                    return "right";
                case ChartAxisTitlePosition.Top:
                    return "top";
            }

            return value.ToString();
        }
    }
}

