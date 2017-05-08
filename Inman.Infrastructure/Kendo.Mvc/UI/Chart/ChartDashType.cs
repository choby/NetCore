namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the line dash type.
    /// </summary>
    public enum ChartDashType
    {
        /// <summary>
        /// A solid line.
        /// </summary>
        Solid,
        /// <summary>
        /// A line consisting of dots.
        /// </summary>
        Dot,
        /// <summary>
        /// A line consisting of dashes.
        /// </summary>
        Dash,
        /// <summary>
        /// A line consisting of a repeating pattern of long dashes.
        /// </summary>
        LongDash,
        /// <summary>
        /// A line consisting of a repeating pattern of dashes and dots.
        /// </summary>
        DashDot,
        /// <summary>
        /// A line consisting of a repeating pattern of long dashes and dots.
        /// </summary>
        LongDashDot,
        /// <summary>
        /// A line consisting of a repeating pattern of long dashes and two dots.
        /// </summary>
        LongDashDotDot
    }

    internal static class ChartDashTypeExtensions
    {
        internal static string Serialize(this ChartDashType value)
        {
            switch (value)
            {
                case ChartDashType.Solid:
                    return "solid";
                case ChartDashType.Dot:
                    return "dot";
                case ChartDashType.Dash:
                    return "dash";
                case ChartDashType.LongDash:
                    return "longDash";
                case ChartDashType.DashDot:
                    return "dashDot";
                case ChartDashType.LongDashDot:
                    return "longDashDot";
                case ChartDashType.LongDashDotDot:
                    return "longDashDotDot";
            }

            return value.ToString();
        }
    }
}

