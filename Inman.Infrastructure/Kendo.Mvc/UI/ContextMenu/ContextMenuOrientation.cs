namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the orientation in which the menu items will be ordered
    /// </summary>
    public enum ContextMenuOrientation
    {
        /// <summary>
        /// Items are oredered vertically
        /// </summary>
        Vertical,
        /// <summary>
        /// Items are oredered horizontally
        /// </summary>
        Horizontal
    }

    internal static class ContextMenuOrientationExtensions
    {
        internal static string Serialize(this ContextMenuOrientation value)
        {
            switch (value)
            {
                case ContextMenuOrientation.Vertical:
                    return "vertical";
                case ContextMenuOrientation.Horizontal:
                    return "horizontal";
            }

            return value.ToString();
        }
    }
}

