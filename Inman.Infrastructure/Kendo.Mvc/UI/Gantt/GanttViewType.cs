namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The view type. Supported types are "day", "week", "month" and "year".
    /// </summary>
    public enum GanttViewType
    {
        Day,
        Week,
        Month,
        Year
    }

    internal static class GanttViewTypeExtensions
    {
        internal static string Serialize(this GanttViewType value)
        {
            switch (value)
            {
                case GanttViewType.Day:
                    return "day";
                case GanttViewType.Week:
                    return "week";
                case GanttViewType.Month:
                    return "month";
                case GanttViewType.Year:
                    return "year";
            }

            return value.ToString();
        }
    }
}

