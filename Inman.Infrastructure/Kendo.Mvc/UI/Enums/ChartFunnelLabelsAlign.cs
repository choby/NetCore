namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the position of pie chart labels.
    /// </summary>
    public enum ChartFunnelLabelsAlign
    {
        /// <summary>
        /// The labels are positioned on the top of the funnel chart.
        /// </summary>
        Center,
        /// <summary>
        /// The labels are positioned on the left side of the chart.
        /// </summary>
        Right,
        /// <summary>
        /// The labels are positioned on the right side of the chart.
        /// </summary>
        Left
    }

    internal static class ChartFunnelLabelsAlignExtensions
    {
        internal static string Serialize(this ChartFunnelLabelsAlign value)
        {
            switch (value)
            {
                case ChartFunnelLabelsAlign.Center:
                    return "center";
                case ChartFunnelLabelsAlign.Right:
                    return "right";
                case ChartFunnelLabelsAlign.Left:
                    return "left";
            }

            return value.ToString();
        }
    }
}

