namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred line rendering style.
    /// </summary>
    public enum ChartAreaStyle
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

    internal static class ChartAreaStyleExtensions
    {
        internal static string Serialize(this ChartAreaStyle value)
        {
            switch (value)
            {
                case ChartAreaStyle.Normal:
                    return "normal";
                case ChartAreaStyle.Step:
                    return "step";
                case ChartAreaStyle.Smooth:
                    return "smooth";
            }

            return value.ToString();
        }
    }
}

