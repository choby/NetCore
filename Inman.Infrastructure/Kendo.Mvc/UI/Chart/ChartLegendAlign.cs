namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the legend align.
    /// </summary>
    public enum ChartLegendAlign
    {
        /// <summary>
        /// The legend is aligned to the center.
        /// </summary>
        Center,
        /// <summary>
        /// The legend is aligned to the end.
        /// </summary>
        End,
        /// <summary>
        /// The legend is aligned to the start.
        /// </summary>
        Start
    }

    internal static class ChartLegendAlignExtensions
    {
        internal static string Serialize(this ChartLegendAlign value)
        {
            switch (value)
            {
                case ChartLegendAlign.Center:
                    return "center";
                case ChartLegendAlign.End:
                    return "end";
                case ChartLegendAlign.Start:
                    return "start";
            }

            return value.ToString();
        }
    }
}

