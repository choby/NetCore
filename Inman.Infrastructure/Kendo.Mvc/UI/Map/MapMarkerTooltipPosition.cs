namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The position relative to the target element, at which tlhe tooltip will be shown. Predefined values are "bottom", "top", "left", "right", "center".
    /// </summary>
    public enum MapMarkerTooltipPosition
    {
        Bottom,
        Top,
        Left,
        Right
    }

    internal static class MapMarkerTooltipPositionExtensions
    {
        internal static string Serialize(this MapMarkerTooltipPosition value)
        {
            switch (value)
            {
                case MapMarkerTooltipPosition.Bottom:
                    return "bottom";
                case MapMarkerTooltipPosition.Top:
                    return "top";
                case MapMarkerTooltipPosition.Left:
                    return "left";
                case MapMarkerTooltipPosition.Right:
                    return "right";
            }

            return value.ToString();
        }
    }
}

