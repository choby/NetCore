namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the position of pie chart labels.
    /// </summary>
    public enum ChartPieLabelsPosition
    {
        /// <summary>
        /// The label is positioned at the center of the pie segment.
        /// </summary>
        Center,
        /// <summary>
        /// The label is positioned inside, near the end of the pie segment.
        /// </summary>
        InsideEnd,
        /// <summary>
        /// The label is positioned outside, near the end of the pie segment.
        /// </summary>
        OutsideEnd
    }

    internal static class ChartPieLabelsPositionExtensions
    {
        internal static string Serialize(this ChartPieLabelsPosition value)
        {
            switch (value)
            {
                case ChartPieLabelsPosition.Center:
                    return "center";
                case ChartPieLabelsPosition.InsideEnd:
                    return "insideEnd";
                case ChartPieLabelsPosition.OutsideEnd:
                    return "outsideEnd";
            }

            return value.ToString();
        }
    }
}

