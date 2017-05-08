namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The position relative to the target element, at which the tooltip will be shown. Predefined values are "bottom", "top", "left", "right", "center".
    /// </summary>
    public enum MapMarkerDefaultsTooltipPosition
    {
        Bottom,
        Top,
        Left,
        Right
    }

    internal static class MapMarkerDefaultsTooltipPositionExtensions
    {
        internal static string Serialize(this MapMarkerDefaultsTooltipPosition value)
        {
            switch (value)
            {
                case MapMarkerDefaultsTooltipPosition.Bottom:
                    return "bottom";
                case MapMarkerDefaultsTooltipPosition.Top:
                    return "top";
                case MapMarkerDefaultsTooltipPosition.Left:
                    return "left";
                case MapMarkerDefaultsTooltipPosition.Right:
                    return "right";
            }

            return value.ToString();
        }
    }
}

