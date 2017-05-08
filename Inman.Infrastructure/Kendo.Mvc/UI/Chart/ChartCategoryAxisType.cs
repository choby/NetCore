namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the category axis type.
    /// </summary>
    public enum ChartCategoryAxisType
    {
        /// <summary>
        /// Discrete category axis.
        /// </summary>
        Category,
        /// <summary>
        /// Specialized axis for displaying chronological data.
        /// </summary>
        Date
    }

    internal static class ChartCategoryAxisTypeExtensions
    {
        internal static string Serialize(this ChartCategoryAxisType value)
        {
            switch (value)
            {
                case ChartCategoryAxisType.Category:
                    return "categoryAxis";
                case ChartCategoryAxisType.Date:
                    return "date";
            }

            return value.ToString();
        }
    }
}

