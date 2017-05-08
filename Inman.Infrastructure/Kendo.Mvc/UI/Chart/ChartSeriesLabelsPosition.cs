namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the position of the labels.
    /// </summary>
    public enum ChartSeriesLabelsPosition
    {
        /// <summary>
        /// The label is positioned at the top of the marker.
        /// </summary>
        Above,
        /// <summary>
        /// the label is positioned at the bottom of the marker.
        /// </summary>
        Below,
        /// <summary>
        /// The label is positioned at the bottom of the segment.
        /// </summary>
        Bottom,
        /// <summary>
        /// the label is positioned at the center.
        /// </summary>
        Center,
        /// <summary>
        /// The label is positioned inside, near the base of the bar.
        /// </summary>
        InsideBase,
        /// <summary>
        /// The label is positioned inside, near the end of the point.
        /// </summary>
        InsideEnd,
        /// <summary>
        /// The label is positioned to the left of the marker.
        /// </summary>
        Left,
        /// <summary>
        /// The label is positioned outside, near the end of the point
        /// </summary>
        OutsideEnd,
        /// <summary>
        /// The label is positioned to the right of the marker.
        /// </summary>
        Right,
        /// <summary>
        /// The label is positioned at the top of the segment.
        /// </summary>
        Top
    }

    internal static class ChartSeriesLabelsPositionExtensions
    {
        internal static string Serialize(this ChartSeriesLabelsPosition value)
        {
            switch (value)
            {
                case ChartSeriesLabelsPosition.Above:
                    return "above";
                case ChartSeriesLabelsPosition.Below:
                    return "below";
                case ChartSeriesLabelsPosition.Bottom:
                    return "bottom";
                case ChartSeriesLabelsPosition.Center:
                    return "center";
                case ChartSeriesLabelsPosition.InsideBase:
                    return "insideBase";
                case ChartSeriesLabelsPosition.InsideEnd:
                    return "insideEnd";
                case ChartSeriesLabelsPosition.Left:
                    return "left";
                case ChartSeriesLabelsPosition.OutsideEnd:
                    return "outsideEnd";
                case ChartSeriesLabelsPosition.Right:
                    return "right";
                case ChartSeriesLabelsPosition.Top:
                    return "top";
            }

            return value.ToString();
        }
    }
}

