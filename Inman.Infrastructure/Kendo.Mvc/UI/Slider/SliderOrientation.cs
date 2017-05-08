namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The orientation of a Slider
    /// </summary>
    public enum SliderOrientation
    {
        /// <summary>
        /// The slider is oriented horizontally
        /// </summary>
        Horizontal,
        /// <summary>
        /// The slider is oriented vertically
        /// </summary>
        Vertical
    }

    internal static class SliderOrientationExtensions
    {
        internal static string Serialize(this SliderOrientation value)
        {
            switch (value)
            {
                case SliderOrientation.Horizontal:
                    return "horizontal";
                case SliderOrientation.Vertical:
                    return "vertical";
            }

            return value.ToString();
        }
    }
}

