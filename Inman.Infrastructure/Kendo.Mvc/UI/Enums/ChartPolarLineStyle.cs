namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred rendering style.
    /// </summary>
    public enum ChartPolarLineStyle
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

    internal static class ChartPolarLineStyleExtensions
    {
        internal static string Serialize(this ChartPolarLineStyle value)
        {
            switch (value)
            {
                case ChartPolarLineStyle.Normal:
                    return "normal";
                case ChartPolarLineStyle.Smooth:
                    return "smooth";
            }

            return value.ToString();
        }
    }
}

