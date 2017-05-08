namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The custom filter logic type.
    /// </summary>
    public enum SpreadsheetFilterLogic
    {
        /// <summary>
        /// And logic
        /// </summary>
        And,
        /// <summary>
        /// Or logic
        /// </summary>
        Or
    }

    internal static class SpreadsheetFilterLogicExtensions
    {
        internal static string Serialize(this SpreadsheetFilterLogic value)
        {
            switch (value)
            {
                case SpreadsheetFilterLogic.And:
                    return "and";
                case SpreadsheetFilterLogic.Or:
                    return "or";
            }

            return value.ToString();
        }
    }
}

