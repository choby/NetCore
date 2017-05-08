namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents available types of calendar views.
    /// </summary>
    public enum CalendarView
    {
        /// <summary>
        /// Shows the days of the current month
        /// </summary>
        Month,
        /// <summary>
        /// Shows the months of the current year
        /// </summary>
        Year,
        /// <summary>
        /// Shows the years of the current decade
        /// </summary>
        Decade,
        /// <summary>
        /// Shows the decades of the current century
        /// </summary>
        Century
    }

    internal static class CalendarViewExtensions
    {
        internal static string Serialize(this CalendarView value)
        {
            switch (value)
            {
                case CalendarView.Month:
                    return "month";
                case CalendarView.Year:
                    return "year";
                case CalendarView.Decade:
                    return "decade";
                case CalendarView.Century:
                    return "century";
            }

            return value.ToString();
        }
    }
}

