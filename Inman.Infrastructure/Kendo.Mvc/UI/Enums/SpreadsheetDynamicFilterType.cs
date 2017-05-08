namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The dynamic filter type.
    /// </summary>
    public enum SpreadsheetDynamicFilterType
    {
        /// <summary>
        /// Above average
        /// </summary>
        AboveAverage,
        /// <summary>
        /// Below average
        /// </summary>
        BelowAverage,
        /// <summary>
        /// Tomorrow
        /// </summary>
        Tomorrow,
        /// <summary>
        /// Today
        /// </summary>
        Today,
        /// <summary>
        /// Yesterday
        /// </summary>
        Yesterday,
        /// <summary>
        /// Next week
        /// </summary>
        NextWeek,
        /// <summary>
        /// This Week
        /// </summary>
        ThisWeek,
        /// <summary>
        /// Last week
        /// </summary>
        LastWeek,
        /// <summary>
        /// Next month
        /// </summary>
        NextMonth,
        /// <summary>
        /// This month
        /// </summary>
        ThisMonth,
        /// <summary>
        /// Last month
        /// </summary>
        LastMonth,
        /// <summary>
        /// Next quarter
        /// </summary>
        NextQuarter,
        /// <summary>
        /// This quarter
        /// </summary>
        ThisQuarter,
        /// <summary>
        /// Last quarter
        /// </summary>
        LastQuarter,
        /// <summary>
        /// Next year
        /// </summary>
        NextYear,
        /// <summary>
        /// This year
        /// </summary>
        ThisYear,
        /// <summary>
        /// Last year
        /// </summary>
        LastYear,
        /// <summary>
        /// Year to date
        /// </summary>
        YearToDate
    }

    internal static class SpreadsheetDynamicFilterTypeExtensions
    {
        internal static string Serialize(this SpreadsheetDynamicFilterType value)
        {
            switch (value)
            {
                case SpreadsheetDynamicFilterType.AboveAverage:
                    return "aboveAverage";
                case SpreadsheetDynamicFilterType.BelowAverage:
                    return "belowAverage";
                case SpreadsheetDynamicFilterType.Tomorrow:
                    return "tomorrow";
                case SpreadsheetDynamicFilterType.Today:
                    return "today";
                case SpreadsheetDynamicFilterType.Yesterday:
                    return "yesterday";
                case SpreadsheetDynamicFilterType.NextWeek:
                    return "nextWeek";
                case SpreadsheetDynamicFilterType.ThisWeek:
                    return "thisWeek";
                case SpreadsheetDynamicFilterType.LastWeek:
                    return "lastWeek";
                case SpreadsheetDynamicFilterType.NextMonth:
                    return "nextMonth";
                case SpreadsheetDynamicFilterType.ThisMonth:
                    return "thisMonth";
                case SpreadsheetDynamicFilterType.LastMonth:
                    return "lastMonth";
                case SpreadsheetDynamicFilterType.NextQuarter:
                    return "nextQuarter";
                case SpreadsheetDynamicFilterType.ThisQuarter:
                    return "thisQuarter";
                case SpreadsheetDynamicFilterType.LastQuarter:
                    return "lastQuarter";
                case SpreadsheetDynamicFilterType.NextYear:
                    return "nextYear";
                case SpreadsheetDynamicFilterType.ThisYear:
                    return "thisYear";
                case SpreadsheetDynamicFilterType.LastYear:
                    return "lastYear";
                case SpreadsheetDynamicFilterType.YearToDate:
                    return "yearToDate";
            }

            return value.ToString();
        }
    }
}

