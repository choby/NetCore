namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred line rendering style.
    /// </summary>
    public enum ChartSeriesLineStyle
    {
        /// <summary>
        /// Points will be connected with straight line.
        /// </summary>
        Normal,
        /// <summary>
        /// Points will be connected with a line at right angles.
        /// </summary>
        Step,
        /// <summary>
        /// Points will be connected with smooth line.
        /// </summary>
        Smooth
    }

    internal static class ChartSeriesLineStyleExtensions
    {
        internal static string Serialize(this ChartSeriesLineStyle value)
        {
            switch (value)
            {
                case ChartSeriesLineStyle.Normal:
                    return "normal";
                case ChartSeriesLineStyle.Step:
                    return "step";
                case ChartSeriesLineStyle.Smooth:
                    return "smooth";
            }

            return value.ToString();
        }
    }
}

