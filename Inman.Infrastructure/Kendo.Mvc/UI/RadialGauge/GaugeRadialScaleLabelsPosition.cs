namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Sets the labels position
    /// </summary>
    public enum GaugeRadialScaleLabelsPosition
    {
        /// <summary>
        /// The labels are positioned inside.
        /// </summary>
        Inside,
        /// <summary>
        /// The labels are positioned outside.
        /// </summary>
        Outside
    }

    internal static class GaugeRadialScaleLabelsPositionExtensions
    {
        internal static string Serialize(this GaugeRadialScaleLabelsPosition value)
        {
            switch (value)
            {
                case GaugeRadialScaleLabelsPosition.Inside:
                    return "inside";
                case GaugeRadialScaleLabelsPosition.Outside:
                    return "outside";
            }

            return value.ToString();
        }
    }
}

