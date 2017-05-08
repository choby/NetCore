namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the orientation in which the splitter panes will be ordered
    /// </summary>
    public enum SplitterOrientation
    {
        /// <summary>
        /// Panes are oredered horizontally
        /// </summary>
        Horizontal,
        /// <summary>
        /// Panes are oredered vertically
        /// </summary>
        Vertical
    }

    internal static class SplitterOrientationExtensions
    {
        internal static string Serialize(this SplitterOrientation value)
        {
            switch (value)
            {
                case SplitterOrientation.Horizontal:
                    return "horizontal";
                case SplitterOrientation.Vertical:
                    return "vertical";
            }

            return value.ToString();
        }
    }
}

