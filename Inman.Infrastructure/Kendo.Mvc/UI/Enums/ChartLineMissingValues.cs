namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the behavior for handling missing values in the series.
    /// </summary>
    public enum ChartLineMissingValues
    {
        /// <summary>
        /// The line stops before the missing point and continues after it.
        /// </summary>
        Gap,
        /// <summary>
        /// The value is interpolated from neighboring points.
        /// </summary>
        Interpolate,
        /// <summary>
        /// The value is assumed to be zero.
        /// </summary>
        Zero
    }

    internal static class ChartLineMissingValuesExtensions
    {
        internal static string Serialize(this ChartLineMissingValues value)
        {
            switch (value)
            {
                case ChartLineMissingValues.Gap:
                    return "gap";
                case ChartLineMissingValues.Interpolate:
                    return "interpolate";
                case ChartLineMissingValues.Zero:
                    return "zero";
            }

            return value.ToString();
        }
    }
}

