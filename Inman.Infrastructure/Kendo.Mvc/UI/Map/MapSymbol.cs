namespace Kendo.Mvc.UI
{
    /// <summary>
    /// The bubble layer symbol type. Supported symbols are "circle" and "square".
    /// </summary>
    public enum MapSymbol
    {
        Circle,
        Square
    }

    internal static class MapSymbolExtensions
    {
        internal static string Serialize(this MapSymbol value)
        {
            switch (value)
            {
                case MapSymbol.Circle:
                    return "circle";
                case MapSymbol.Square:
                    return "square";
            }

            return value.ToString();
        }
    }
}

