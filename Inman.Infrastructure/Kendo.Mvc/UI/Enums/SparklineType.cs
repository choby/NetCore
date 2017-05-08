namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Defines the possible series orientation.
    /// </summary>
    public enum SparklineType
    {
        /// <summary>
        /// Area series.
        /// </summary>
        Area,
        /// <summary>
        /// Bar Series (synonym for Column in sparklines)
        /// </summary>
        Bar,
        /// <summary>
        /// Bullet series.
        /// </summary>
        Bullet,
        /// <summary>
        /// Column series.
        /// </summary>
        Column,
        /// <summary>
        /// Line series.
        /// </summary>
        Line,
        /// <summary>
        /// Pie series.
        /// </summary>
        Pie
    }

    internal static class SparklineTypeExtensions
    {
        internal static string Serialize(this SparklineType value)
        {
            switch (value)
            {
                case SparklineType.Area:
                    return "area";
                case SparklineType.Bar:
                    return "bar";
                case SparklineType.Bullet:
                    return "bullet";
                case SparklineType.Column:
                    return "column";
                case SparklineType.Line:
                    return "line";
                case SparklineType.Pie:
                    return "pie";
            }

            return value.ToString();
        }
    }
}

