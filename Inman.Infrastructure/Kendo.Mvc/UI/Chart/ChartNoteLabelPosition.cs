namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the position of the labels.
    /// </summary>
    public enum ChartNoteLabelPosition
    {
        /// <summary>
        /// The label is positioned inside of the icon.
        /// </summary>
        Inside,
        /// <summary>
        /// The label is positioned outside of the icon.
        /// </summary>
        Outside
    }

    internal static class ChartNoteLabelPositionExtensions
    {
        internal static string Serialize(this ChartNoteLabelPosition value)
        {
            switch (value)
            {
                case ChartNoteLabelPosition.Inside:
                    return "inside";
                case ChartNoteLabelPosition.Outside:
                    return "outside";
            }

            return value.ToString();
        }
    }
}

