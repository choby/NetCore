namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the rotation of the labels.
    /// </summary>
    public enum ChartAxisLabelRotationAlignment
    {
        /// <summary>
        /// Labels are aligned to the end.
        /// </summary>
        End,
        /// <summary>
        /// Labels are aligned to the center.
        /// </summary>
        Center
    }

    internal static class ChartAxisLabelRotationAlignmentExtensions
    {
        internal static string Serialize(this ChartAxisLabelRotationAlignment value)
        {
            switch (value)
            {
                case ChartAxisLabelRotationAlignment.End:
                    return "end";
                case ChartAxisLabelRotationAlignment.Center:
                    return "center";
            }

            return value.ToString();
        }
    }
}

