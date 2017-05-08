namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred rendering style.
    /// </summary>
    public enum ChartRadarLineStyle
    {
        /// <summary>
        /// Points will be connected with a straight line.
        /// </summary>
        Normal,
        /// <summary>
        /// Points will be connected with a smooth line.
        /// </summary>
        Smooth
    }

    internal static class ChartRadarLineStyleExtensions
    {
        internal static string Serialize(this ChartRadarLineStyle value)
        {
            switch (value)
            {
                case ChartRadarLineStyle.Normal:
                    return "normal";
                case ChartRadarLineStyle.Smooth:
                    return "smooth";
            }

            return value.ToString();
        }
    }
}

