namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The bing map tile types. Possible options.
    /// </summary>
    public enum MapLayersImagerySet
    {
        Aerial,
        AerialWithLabels,
        Birdseye,
        BirdseyeWithLabels,
        Road
    }

    internal static class MapLayersImagerySetExtensions
    {
        internal static string Serialize(this MapLayersImagerySet value)
        {
            switch (value)
            {
                case MapLayersImagerySet.Aerial:
                    return "aerial";
                case MapLayersImagerySet.AerialWithLabels:
                    return "aerialWithLabels";
                case MapLayersImagerySet.Birdseye:
                    return "birdseye";
                case MapLayersImagerySet.BirdseyeWithLabels:
                    return "birdseyeWithLabels";
                case MapLayersImagerySet.Road:
                    return "road";
            }

            return value.ToString();
        }
    }
}

