namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the base time interval for the axis.
    /// </summary>
    public enum ChartAxisBaseUnit
    {
        /// <summary>
        /// The time interval is seconds.
        /// </summary>
        Seconds,
        /// <summary>
        /// The time interval is minutes.
        /// </summary>
        Minutes,
        /// <summary>
        /// The time interval is hours.
        /// </summary>
        Hours,
        /// <summary>
        /// The time interval is days.
        /// </summary>
        Days,
        /// <summary>
        /// The time interval is weeks.
        /// </summary>
        Weeks,
        /// <summary>
        /// The time interval is months.
        /// </summary>
        Months,
        /// <summary>
        /// The time interval is years.
        /// </summary>
        Years,
        /// <summary>
        /// Automatic base unit based on limit set from MaxDateGroups. Note that the BaseUnitStep setting will be disregarded.
        /// </summary>
        Fit
    }

    internal static class ChartAxisBaseUnitExtensions
    {
        internal static string Serialize(this ChartAxisBaseUnit value)
        {
            switch (value)
            {
                case ChartAxisBaseUnit.Seconds:
                    return "seconds";
                case ChartAxisBaseUnit.Minutes:
                    return "minutes";
                case ChartAxisBaseUnit.Hours:
                    return "hours";
                case ChartAxisBaseUnit.Days:
                    return "days";
                case ChartAxisBaseUnit.Weeks:
                    return "weeks";
                case ChartAxisBaseUnit.Months:
                    return "months";
                case ChartAxisBaseUnit.Years:
                    return "years";
                case ChartAxisBaseUnit.Fit:
                    return "fit";
            }

            return value.ToString();
        }
    }
}

