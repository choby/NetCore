namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the shape of the marker.
    /// </summary>
    public enum ChartMarkerShape
    {
        /// <summary>
        /// The marker shape is circle.
        /// </summary>
        Circle,
        /// <summary>
        /// The marker shape is cross.
        /// </summary>
        Cross,
        /// <summary>
        /// The marker shape is square.
        /// </summary>
        Square,
        /// <summary>
        /// The marker shape is triangle.
        /// </summary>
        Triangle
    }

    internal static class ChartMarkerShapeExtensions
    {
        internal static string Serialize(this ChartMarkerShape value)
        {
            switch (value)
            {
                case ChartMarkerShape.Circle:
                    return "circle";
                case ChartMarkerShape.Cross:
                    return "cross";
                case ChartMarkerShape.Square:
                    return "square";
                case ChartMarkerShape.Triangle:
                    return "triangle";
            }

            return value.ToString();
        }
    }
}

