namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The criterion operator type.
    /// </summary>
    public enum SpreadsheetFilterOperator
    {
        /// <summary>
        /// contains the value
        /// </summary>
        Contains,
        /// <summary>
        /// does not contain the value
        /// </summary>
        DoesNotContain,
        /// <summary>
        /// starts with the value
        /// </summary>
        StartsWith,
        /// <summary>
        /// ends with the value
        /// </summary>
        EndsWith,
        /// <summary>
        /// is the same as the value
        /// </summary>
        EqualTo,
        /// <summary>
        /// is not the same as the value
        /// </summary>
        NotEqualTo,
        /// <summary>
        /// is greater than the value
        /// </summary>
        LowerThan,
        /// <summary>
        /// is less than the value
        /// </summary>
        GreaterThan,
        /// <summary>
        /// is greater than or equal to the value
        /// </summary>
        GreaterThanOrEqualTo,
        /// <summary>
        /// is less than or equal to the value
        /// </summary>
        LowerThanOrEqualTo
    }

    internal static class SpreadsheetFilterOperatorExtensions
    {
        internal static string Serialize(this SpreadsheetFilterOperator value)
        {
            switch (value)
            {
                case SpreadsheetFilterOperator.Contains:
                    return "contains";
                case SpreadsheetFilterOperator.DoesNotContain:
                    return "doesnotcontain";
                case SpreadsheetFilterOperator.StartsWith:
                    return "startswith";
                case SpreadsheetFilterOperator.EndsWith:
                    return "endswith";
                case SpreadsheetFilterOperator.EqualTo:
                    return "eq";
                case SpreadsheetFilterOperator.NotEqualTo:
                    return "neq";
                case SpreadsheetFilterOperator.LowerThan:
                    return "lt";
                case SpreadsheetFilterOperator.GreaterThan:
                    return "gt";
                case SpreadsheetFilterOperator.GreaterThanOrEqualTo:
                    return "gte";
                case SpreadsheetFilterOperator.LowerThanOrEqualTo:
                    return "lte";
            }

            return value.ToString();
        }
    }
}

