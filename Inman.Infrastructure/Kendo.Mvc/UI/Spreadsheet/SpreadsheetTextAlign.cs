namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the text alignment in the cell
    /// </summary>
    public enum SpreadsheetTextAlign
    {
        Left,
        Right,
        Center,
        Justify
    }

    internal static class SpreadsheetTextAlignExtensions
    {
        internal static string Serialize(this SpreadsheetTextAlign value)
        {
            switch (value)
            {
                case SpreadsheetTextAlign.Left:
                    return "left";
                case SpreadsheetTextAlign.Right:
                    return "right";
                case SpreadsheetTextAlign.Center:
                    return "center";
                case SpreadsheetTextAlign.Justify:
                    return "justify";
            }

            return value.ToString();
        }
    }
}

