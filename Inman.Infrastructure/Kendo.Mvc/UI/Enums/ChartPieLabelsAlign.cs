namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the position of pie chart labels.
    /// </summary>
    public enum ChartPieLabelsAlign
    {
        /// <summary>
        /// The label is positioned in a circle around the chart.
        /// </summary>
        Circle,
        /// <summary>
        /// the label is positioned in a column around the chart.
        /// </summary>
        Column
    }

    internal static class ChartPieLabelsAlignExtensions
    {
        internal static string Serialize(this ChartPieLabelsAlign value)
        {
            switch (value)
            {
                case ChartPieLabelsAlign.Circle:
                    return "circle";
                case ChartPieLabelsAlign.Column:
                    return "column";
            }

            return value.ToString();
        }
    }
}

