namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The top filter type.
    /// </summary>
    public enum SpreadsheetTopFilterType
    {
        /// <summary>
        /// Top number
        /// </summary>
        TopNumber,
        /// <summary>
        /// Top Percent
        /// </summary>
        TopPercent,
        /// <summary>
        /// Bottom Number
        /// </summary>
        BottomNumber,
        /// <summary>
        /// Bottom Percent
        /// </summary>
        BottomPercent
    }

    internal static class SpreadsheetTopFilterTypeExtensions
    {
        internal static string Serialize(this SpreadsheetTopFilterType value)
        {
            switch (value)
            {
                case SpreadsheetTopFilterType.TopNumber:
                    return "topNumber";
                case SpreadsheetTopFilterType.TopPercent:
                    return "topPercent";
                case SpreadsheetTopFilterType.BottomNumber:
                    return "bottomNumber";
                case SpreadsheetTopFilterType.BottomPercent:
                    return "bottomPercent";
            }

            return value.ToString();
        }
    }
}

