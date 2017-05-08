namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred rendering style.
    /// </summary>
    public enum ChartScatterLineStyle
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

    internal static class ChartScatterLineStyleExtensions
    {
        internal static string Serialize(this ChartScatterLineStyle value)
        {
            switch (value)
            {
                case ChartScatterLineStyle.Normal:
                    return "normal";
                case ChartScatterLineStyle.Smooth:
                    return "smooth";
            }

            return value.ToString();
        }
    }
}

