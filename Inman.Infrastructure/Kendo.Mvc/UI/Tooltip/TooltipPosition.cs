namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents the tooltip position.
    /// </summary>
    public enum TooltipPosition
    {
        /// <summary>
        /// Bottom position
        /// </summary>
        Bottom,
        /// <summary>
        /// Top position
        /// </summary>
        Top,
        /// <summary>
        /// Left position
        /// </summary>
        Left,
        /// <summary>
        /// Right postion
        /// </summary>
        Right,
        /// <summary>
        /// Center postion
        /// </summary>
        Center
    }

    internal static class TooltipPositionExtensions
    {
        internal static string Serialize(this TooltipPosition value)
        {
            switch (value)
            {
                case TooltipPosition.Bottom:
                    return "bottom";
                case TooltipPosition.Top:
                    return "top";
                case TooltipPosition.Left:
                    return "left";
                case TooltipPosition.Right:
                    return "right";
                case TooltipPosition.Center:
                    return "center";
            }

            return value.ToString();
        }
    }
}

