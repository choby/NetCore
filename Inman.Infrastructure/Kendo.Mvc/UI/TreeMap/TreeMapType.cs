namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The layout type for the Treemap.
    /// </summary>
    public enum TreeMapType
    {
        Squarified,
        Horizontal,
        Veritcal
    }

    internal static class TreeMapTypeExtensions
    {
        internal static string Serialize(this TreeMapType value)
        {
            switch (value)
            {
                case TreeMapType.Squarified:
                    return "squarified";
                case TreeMapType.Horizontal:
                    return "horizontal";
                case TreeMapType.Veritcal:
                    return "veritcal";
            }

            return value.ToString();
        }
    }
}

