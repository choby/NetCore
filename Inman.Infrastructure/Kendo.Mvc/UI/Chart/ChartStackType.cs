namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred stack type.
    /// </summary>
    public enum ChartStackType
    {
        /// <summary>
        /// The value of the stack is the sum of all points in the category (or group).
        /// </summary>
        Normal,
        /// <summary>
        /// The value of the stack is always 100% (1.0). Points within the category (or group) are represented as percentages.
        /// </summary>
        Stack100
    }

    internal static class ChartStackTypeExtensions
    {
        internal static string Serialize(this ChartStackType value)
        {
            switch (value)
            {
                case ChartStackType.Normal:
                    return "normal";
                case ChartStackType.Stack100:
                    return "100%";
            }

            return value.ToString();
        }
    }
}

