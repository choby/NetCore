namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The layer type. Supported types are "tile", "bing", "shape", "marker" and "bubble".
    /// </summary>
    public enum MapLayerType
    {
        Bing,
        Tile,
        Shape,
        Marker,
        Bubble
    }

    internal static class MapLayerTypeExtensions
    {
        internal static string Serialize(this MapLayerType value)
        {
            switch (value)
            {
                case MapLayerType.Bing:
                    return "bing";
                case MapLayerType.Tile:
                    return "tile";
                case MapLayerType.Shape:
                    return "shape";
                case MapLayerType.Marker:
                    return "marker";
                case MapLayerType.Bubble:
                    return "bubble";
            }

            return value.ToString();
        }
    }
}

