namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the legend orientation.
    /// </summary>
    public enum ChartLegendOrientation
    {
        /// <summary>
        /// The orientation is horizontal.
        /// </summary>
        Horizontal,
        /// <summary>
        /// The orientation is vertical.
        /// </summary>
        Vertical
    }

    internal static class ChartLegendOrientationExtensions
    {
        internal static string Serialize(this ChartLegendOrientation value)
        {
            switch (value)
            {
                case ChartLegendOrientation.Horizontal:
                    return "horizontal";
                case ChartLegendOrientation.Vertical:
                    return "vertical";
            }

            return value.ToString();
        }
    }
}

