namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the behavior for handling missing values in the series.
    /// </summary>
    public enum ChartAreaMissingValues
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

    internal static class ChartAreaMissingValuesExtensions
    {
        internal static string Serialize(this ChartAreaMissingValues value)
        {
            switch (value)
            {
                case ChartAreaMissingValues.Gap:
                    return "gap";
                case ChartAreaMissingValues.Interpolate:
                    return "interpolate";
                case ChartAreaMissingValues.Zero:
                    return "zero";
            }

            return value.ToString();
        }
    }
}

