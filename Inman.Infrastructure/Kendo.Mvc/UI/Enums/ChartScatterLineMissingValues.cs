namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the behavior for handling missing values in the series.
    /// </summary>
    public enum ChartScatterLineMissingValues
    {
        /// <summary>
        /// The line stops before the missing point and continues after it.
        /// </summary>
        Gap,
        /// <summary>
        /// The value is interpolated from neighboring points.
        /// </summary>
        Interpolate
    }

    internal static class ChartScatterLineMissingValuesExtensions
    {
        internal static string Serialize(this ChartScatterLineMissingValues value)
        {
            switch (value)
            {
                case ChartScatterLineMissingValues.Gap:
                    return "gap";
                case ChartScatterLineMissingValues.Interpolate:
                    return "interpolate";
            }

            return value.ToString();
        }
    }
}

