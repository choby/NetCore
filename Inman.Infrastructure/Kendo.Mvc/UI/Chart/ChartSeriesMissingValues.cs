namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the behavior for handling missing values in the series.
    /// </summary>
    public enum ChartSeriesMissingValues
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

    internal static class ChartSeriesMissingValuesExtensions
    {
        internal static string Serialize(this ChartSeriesMissingValues value)
        {
            switch (value)
            {
                case ChartSeriesMissingValues.Gap:
                    return "gap";
                case ChartSeriesMissingValues.Interpolate:
                    return "interpolate";
                case ChartSeriesMissingValues.Zero:
                    return "zero";
            }

            return value.ToString();
        }
    }
}

