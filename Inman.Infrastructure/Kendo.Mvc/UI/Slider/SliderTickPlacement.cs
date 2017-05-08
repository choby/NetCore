namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Denotes the location of the tick marks in the Slider
    /// </summary>
    public enum SliderTickPlacement
    {
        /// <summary>
        /// No tick marks appear in the component
        /// </summary>
        None,
        /// <summary>
        /// Tick marks are located on the top of a horizontal component or on the left of a vertical component
        /// </summary>
        TopLeft,
        /// <summary>
        /// Tick marks are located on the bottom of a horizontal component or on the right side of a vertical component
        /// </summary>
        BottomRight,
        /// <summary>
        /// Tick marks are located on both sides of the component
        /// </summary>
        Both
    }

    internal static class SliderTickPlacementExtensions
    {
        internal static string Serialize(this SliderTickPlacement value)
        {
            switch (value)
            {
                case SliderTickPlacement.None:
                    return "none";
                case SliderTickPlacement.TopLeft:
                    return "topLeft";
                case SliderTickPlacement.BottomRight:
                    return "bottomRight";
                case SliderTickPlacement.Both:
                    return "both";
            }

            return value.ToString();
        }
    }
}

