namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents the menu item opening direction.
    /// </summary>
    public enum MenuDirection
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

    internal static class MenuDirectionExtensions
    {
        internal static string Serialize(this MenuDirection value)
        {
            switch (value)
            {
                case MenuDirection.Bottom:
                    return "bottom";
                case MenuDirection.Left:
                    return "left";
                case MenuDirection.Right:
                    return "right";
                case MenuDirection.Top:
                    return "top";
            }

            return value.ToString();
        }
    }
}

