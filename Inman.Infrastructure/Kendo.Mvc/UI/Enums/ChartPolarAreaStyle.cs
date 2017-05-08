namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred line rendering style.
    /// </summary>
    public enum ChartPolarAreaStyle
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

    internal static class ChartPolarAreaStyleExtensions
    {
        internal static string Serialize(this ChartPolarAreaStyle value)
        {
            switch (value)
            {
                case ChartPolarAreaStyle.Normal:
                    return "normal";
                case ChartPolarAreaStyle.Smooth:
                    return "smooth";
            }

            return value.ToString();
        }
    }
}

