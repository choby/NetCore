namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The position of the attribution control.
    /// </summary>
    public enum MapControlPosition
    {
        /// <summary>
        /// Positions the control at the top left corner
        /// </summary>
        TopLeft,
        /// <summary>
        /// Positions the control at the top right corner
        /// </summary>
        TopRight,
        /// <summary>
        /// Positions the control at the bottom right corner
        /// </summary>
        BottomRight,
        /// <summary>
        /// Positions the control at the bottom left corner
        /// </summary>
        bottomLeft
    }

    internal static class MapControlPositionExtensions
    {
        internal static string Serialize(this MapControlPosition value)
        {
            switch (value)
            {
                case MapControlPosition.TopLeft:
                    return "topLeft";
                case MapControlPosition.TopRight:
                    return "topRight";
                case MapControlPosition.BottomRight:
                    return "bottomRight";
                case MapControlPosition.bottomLeft:
                    return "bottomLeft";
            }

            return value.ToString();
        }
    }
}

