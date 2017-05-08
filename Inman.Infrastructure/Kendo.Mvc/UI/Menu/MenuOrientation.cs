namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the orientation in which the menu items will be ordered
    /// </summary>
    public enum MenuOrientation
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

    internal static class MenuOrientationExtensions
    {
        internal static string Serialize(this MenuOrientation value)
        {
            switch (value)
            {
                case MenuOrientation.Vertical:
                    return "vertical";
                case MenuOrientation.Horizontal:
                    return "horizontal";
            }

            return value.ToString();
        }
    }
}

