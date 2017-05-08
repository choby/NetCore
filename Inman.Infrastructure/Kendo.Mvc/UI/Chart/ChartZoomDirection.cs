namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the mousehweel zoom type.
    /// </summary>
    public enum ChartZoomDirection
    {
        /// <summary>
        /// Both ends of the selection are moved.
        /// </summary>
        Both,
        /// <summary>
        /// The left selection edge is moved during zoom.
        /// </summary>
        Left,
        /// <summary>
        /// The right selection edge is moved during zoom.
        /// </summary>
        Right
    }

    internal static class ChartZoomDirectionExtensions
    {
        internal static string Serialize(this ChartZoomDirection value)
        {
            switch (value)
            {
                case ChartZoomDirection.Both:
                    return "both";
                case ChartZoomDirection.Left:
                    return "left";
                case ChartZoomDirection.Right:
                    return "right";
            }

            return value.ToString();
        }
    }
}

