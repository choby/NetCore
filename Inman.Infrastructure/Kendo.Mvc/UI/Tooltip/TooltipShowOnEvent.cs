namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents the tooltip position.
    /// </summary>
    public enum TooltipShowOnEvent
    {
        /// <summary>
        /// 
        /// </summary>
        MouseEnter,
        /// <summary>
        /// 
        /// </summary>
        Click,
        /// <summary>
        /// 
        /// </summary>
        Focus
    }

    internal static class TooltipShowOnEventExtensions
    {
        internal static string Serialize(this TooltipShowOnEvent value)
        {
            switch (value)
            {
                case TooltipShowOnEvent.MouseEnter:
                    return "mouseenter";
                case TooltipShowOnEvent.Click:
                    return "click";
                case TooltipShowOnEvent.Focus:
                    return "focus";
            }

            return value.ToString();
        }
    }
}

