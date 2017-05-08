namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the alignment of the labels.
    /// </summary>
    public enum ChartSeriesLabelsAlign
    {
        /// <summary>
        /// the label is positioned at the center of the segment.
        /// </summary>
        Center,
        /// <summary>
        /// The label is positioned in a circle around the chart.
        /// </summary>
        Circle,
        /// <summary>
        /// the label is positioned in a column around the chart.
        /// </summary>
        Column,
        /// <summary>
        /// The label is positioned to the left of the segment.
        /// </summary>
        Left,
        /// <summary>
        /// The label is positioned to the right of the segment.
        /// </summary>
        Right
    }

    internal static class ChartSeriesLabelsAlignExtensions
    {
        internal static string Serialize(this ChartSeriesLabelsAlign value)
        {
            switch (value)
            {
                case ChartSeriesLabelsAlign.Center:
                    return "center";
                case ChartSeriesLabelsAlign.Circle:
                    return "circle";
                case ChartSeriesLabelsAlign.Column:
                    return "column";
                case ChartSeriesLabelsAlign.Left:
                    return "left";
                case ChartSeriesLabelsAlign.Right:
                    return "right";
            }

            return value.ToString();
        }
    }
}

