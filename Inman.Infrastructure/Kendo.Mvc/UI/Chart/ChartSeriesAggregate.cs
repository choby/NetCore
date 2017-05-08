namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the preferred series aggregate.
    /// </summary>
    public enum ChartSeriesAggregate
    {
        /// <summary>
        /// The average of all values for the date period.
        /// </summary>
        Avg,
        /// <summary>
        /// The number of values for the date period.
        /// </summary>
        Count,
        /// <summary>
        /// The first of all values for the date period.
        /// </summary>
        First,
        /// <summary>
        /// The highest value for the date period.
        /// </summary>
        Max,
        /// <summary>
        /// The lowest value for the date period.
        /// </summary>
        Min,
        /// <summary>
        /// The sum of all values for the date period.
        /// </summary>
        Sum,
        /// <summary>
        /// The sum of all values for the date period. If there are not data for the current period of time the aggregate will return 'null'(instead of 'zero' for the sum aggregate).
        /// </summary>
        SumOrNull
    }

    internal static class ChartSeriesAggregateExtensions
    {
        internal static string Serialize(this ChartSeriesAggregate value)
        {
            switch (value)
            {
                case ChartSeriesAggregate.Avg:
                    return "avg";
                case ChartSeriesAggregate.Count:
                    return "count";
                case ChartSeriesAggregate.First:
                    return "first";
                case ChartSeriesAggregate.Max:
                    return "max";
                case ChartSeriesAggregate.Min:
                    return "min";
                case ChartSeriesAggregate.Sum:
                    return "sum";
                case ChartSeriesAggregate.SumOrNull:
                    return "sumOrNull";
            }

            return value.ToString();
        }
    }
}

