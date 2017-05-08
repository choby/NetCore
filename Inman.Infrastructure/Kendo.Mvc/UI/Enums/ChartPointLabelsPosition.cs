namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the position of the labels.
    /// </summary>
    public enum ChartPointLabelsPosition
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
        /// The label is positioned to the left of the marker.
        /// </summary>
        Left,
        /// <summary>
        /// The label is positioned to the right of the marker.
        /// </summary>
        Right
    }

    internal static class ChartPointLabelsPositionExtensions
    {
        internal static string Serialize(this ChartPointLabelsPosition value)
        {
            switch (value)
            {
                case ChartPointLabelsPosition.Above:
                    return "above";
                case ChartPointLabelsPosition.Below:
                    return "below";
                case ChartPointLabelsPosition.Left:
                    return "left";
                case ChartPointLabelsPosition.Right:
                    return "right";
            }

            return value.ToString();
        }
    }
}

