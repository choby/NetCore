namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the legend position.
    /// </summary>
    public enum ChartLegendPosition
    {
        /// <summary>
        /// The legend is positioned on the top
        /// </summary>
        Top,
        /// <summary>
        /// The legend is positioned on the bottom
        /// </summary>
        Bottom,
        /// <summary>
        /// The legend is positioned on the left
        /// </summary>
        Left,
        /// <summary>
        /// The legend is positioned on the right
        /// </summary>
        Right,
        /// <summary>
        /// The legend is positioned using OffsetX and OffsetY
        /// </summary>
        Custom
    }

    internal static class ChartLegendPositionExtensions
    {
        internal static string Serialize(this ChartLegendPosition value)
        {
            switch (value)
            {
                case ChartLegendPosition.Top:
                    return "top";
                case ChartLegendPosition.Bottom:
                    return "bottom";
                case ChartLegendPosition.Left:
                    return "left";
                case ChartLegendPosition.Right:
                    return "right";
                case ChartLegendPosition.Custom:
                    return "custom";
            }

            return value.ToString();
        }
    }
}

