namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The criterion operator type.
    /// </summary>
    public enum TabStripTabPosition
    {
        /// <summary>
        /// tabs are positioned on the top
        /// </summary>
        Top,
        /// <summary>
        /// tabs are positioned on the left
        /// </summary>
        Left,
        /// <summary>
        /// tabs are positioned on the right
        /// </summary>
        Right,
        /// <summary>
        /// tabs are positioned on the bottom
        /// </summary>
        Bottom
    }

    internal static class TabStripTabPositionExtensions
    {
        internal static string Serialize(this TabStripTabPosition value)
        {
            switch (value)
            {
                case TabStripTabPosition.Top:
                    return "top";
                case TabStripTabPosition.Left:
                    return "left";
                case TabStripTabPosition.Right:
                    return "right";
                case TabStripTabPosition.Bottom:
                    return "bottom";
            }

            return value.ToString();
        }
    }
}

