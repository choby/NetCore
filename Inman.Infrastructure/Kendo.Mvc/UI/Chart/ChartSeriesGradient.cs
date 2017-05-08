namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the series gradient.
    /// </summary>
    public enum ChartSeriesGradient
    {
        /// <summary>
        /// The series have glass effect overlay.
        /// </summary>
        Glass,
        /// <summary>
        /// The series do not have grdient.
        /// </summary>
        None,
        /// <summary>
        /// The segments have round bevel effect overlay.
        /// </summary>
        RoundedBevel,
        /// <summary>
        /// The segments have sharp bevel effect overlay.
        /// </summary>
        SharpBevel
    }

    internal static class ChartSeriesGradientExtensions
    {
        internal static string Serialize(this ChartSeriesGradient value)
        {
            switch (value)
            {
                case ChartSeriesGradient.Glass:
                    return "glass";
                case ChartSeriesGradient.None:
                    return "none";
                case ChartSeriesGradient.RoundedBevel:
                    return "roundedBevel";
                case ChartSeriesGradient.SharpBevel:
                    return "sharpBevel";
            }

            return value.ToString();
        }
    }
}

