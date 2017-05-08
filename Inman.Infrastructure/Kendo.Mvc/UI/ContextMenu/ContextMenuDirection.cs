namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents the menu item opening direction.
    /// </summary>
    public enum ContextMenuDirection
    {
        /// <summary>
        /// Bottom direction
        /// </summary>
        Bottom,
        /// <summary>
        /// Left direction
        /// </summary>
        Left,
        /// <summary>
        /// Right direction
        /// </summary>
        Right,
        /// <summary>
        /// Top direction
        /// </summary>
        Top
    }

    internal static class ContextMenuDirectionExtensions
    {
        internal static string Serialize(this ContextMenuDirection value)
        {
            switch (value)
            {
                case ContextMenuDirection.Bottom:
                    return "bottom";
                case ContextMenuDirection.Left:
                    return "left";
                case ContextMenuDirection.Right:
                    return "right";
                case ContextMenuDirection.Top:
                    return "top";
            }

            return value.ToString();
        }
    }
}

