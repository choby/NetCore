namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the text alignment.
    /// </summary>
    public enum ChartTextAlignment
    {
        /// <summary>
        /// The text is aligned to the left.
        /// </summary>
        Left,
        /// <summary>
        /// The text is aligned to the middle
        /// </summary>
        Center,
        /// <summary>
        /// The text is aligned to the right.
        /// </summary>
        Right
    }

    internal static class ChartTextAlignmentExtensions
    {
        internal static string Serialize(this ChartTextAlignment value)
        {
            switch (value)
            {
                case ChartTextAlignment.Left:
                    return "left";
                case ChartTextAlignment.Center:
                    return "center";
                case ChartTextAlignment.Right:
                    return "right";
            }

            return value.ToString();
        }
    }
}

