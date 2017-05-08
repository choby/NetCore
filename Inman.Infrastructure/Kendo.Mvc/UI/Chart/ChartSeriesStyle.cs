namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred rendering style.
    /// </summary>
    public enum ChartSeriesStyle
    {
        /// <summary>
        /// Points will be connected with a straight line.
        /// </summary>
        Normal,
        /// <summary>
        /// Points will be connected with a smooth line.
        /// </summary>
        Smooth,
        /// <summary>
        /// Points will be connected with a line at right angles.
        /// </summary>
        Step
    }

    internal static class ChartSeriesStyleExtensions
    {
        internal static string Serialize(this ChartSeriesStyle value)
        {
            switch (value)
            {
                case ChartSeriesStyle.Normal:
                    return "normal";
                case ChartSeriesStyle.Smooth:
                    return "smooth";
                case ChartSeriesStyle.Step:
                    return "step";
            }

            return value.ToString();
        }
    }
}

