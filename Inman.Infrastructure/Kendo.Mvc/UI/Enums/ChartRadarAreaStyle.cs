namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred line rendering style.
    /// </summary>
    public enum ChartRadarAreaStyle
    {
        /// <summary>
        /// Points will be connected with straight line.
        /// </summary>
        Normal,
        /// <summary>
        /// Points will be connected with smooth line.
        /// </summary>
        Smooth
    }

    internal static class ChartRadarAreaStyleExtensions
    {
        internal static string Serialize(this ChartRadarAreaStyle value)
        {
            switch (value)
            {
                case ChartRadarAreaStyle.Normal:
                    return "normal";
                case ChartRadarAreaStyle.Smooth:
                    return "smooth";
            }

            return value.ToString();
        }
    }
}

