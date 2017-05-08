namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The marker shape. Supported shapes are "pin" and "pinTarget".
    /// </summary>
    public enum MapMarkersShape
    {
        Pin,
        PinTarget
    }

    internal static class MapMarkersShapeExtensions
    {
        internal static string Serialize(this MapMarkersShape value)
        {
            switch (value)
            {
                case MapMarkersShape.Pin:
                    return "pin";
                case MapMarkersShape.PinTarget:
                    return "pinTarget";
            }

            return value.ToString();
        }
    }
}

