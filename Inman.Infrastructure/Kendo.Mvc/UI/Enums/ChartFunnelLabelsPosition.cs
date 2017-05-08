namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the position of pie chart labels.
    /// </summary>
    public enum ChartFunnelLabelsPosition
    {
        /// <summary>
        /// The label is positioned at the center of the funnel segment.
        /// </summary>
        Center,
        /// <summary>
        /// The label is positioned at the top of the label area.
        /// </summary>
        Top,
        /// <summary>
        /// The label is positioned at the bottom of the label area.
        /// </summary>
        Bottom
    }

    internal static class ChartFunnelLabelsPositionExtensions
    {
        internal static string Serialize(this ChartFunnelLabelsPosition value)
        {
            switch (value)
            {
                case ChartFunnelLabelsPosition.Center:
                    return "center";
                case ChartFunnelLabelsPosition.Top:
                    return "top";
                case ChartFunnelLabelsPosition.Bottom:
                    return "bottom";
            }

            return value.ToString();
        }
    }
}

