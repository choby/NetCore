namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the position of the labels.
    /// </summary>
    public enum ChartBarLabelsPosition
    {
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
        /// The label is positioned outside, near the end of the point
        /// </summary>
        OutsideEnd
    }

    internal static class ChartBarLabelsPositionExtensions
    {
        internal static string Serialize(this ChartBarLabelsPosition value)
        {
            switch (value)
            {
                case ChartBarLabelsPosition.Center:
                    return "center";
                case ChartBarLabelsPosition.InsideBase:
                    return "insideBase";
                case ChartBarLabelsPosition.InsideEnd:
                    return "insideEnd";
                case ChartBarLabelsPosition.OutsideEnd:
                    return "outsideEnd";
            }

            return value.ToString();
        }
    }
}

