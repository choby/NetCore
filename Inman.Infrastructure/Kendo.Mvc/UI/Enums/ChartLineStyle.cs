namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred rendering style.
    /// </summary>
    public enum ChartLineStyle
    {
        /// <summary>
        /// Points will be connected with straight line.
        /// </summary>
        Normal,
        /// <summary>
        /// Points will be connected with smooth line.
        /// </summary>
        Smooth,
        /// <summary>
        /// Points will be connected with a line at right angles.
        /// </summary>
        Step
    }

    internal static class ChartLineStyleExtensions
    {
        internal static string Serialize(this ChartLineStyle value)
        {
            switch (value)
            {
                case ChartLineStyle.Normal:
                    return "normal";
                case ChartLineStyle.Smooth:
                    return "smooth";
                case ChartLineStyle.Step:
                    return "step";
            }

            return value.ToString();
        }
    }
}

