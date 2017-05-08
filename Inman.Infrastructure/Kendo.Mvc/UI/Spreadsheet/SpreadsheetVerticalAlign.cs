namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the text vertical alignment in the cell
    /// </summary>
    public enum SpreadsheetVerticalAlign
    {
        Top,
        Bottom,
        Center
    }

    internal static class SpreadsheetVerticalAlignExtensions
    {
        internal static string Serialize(this SpreadsheetVerticalAlign value)
        {
            switch (value)
            {
                case SpreadsheetVerticalAlign.Top:
                    return "top";
                case SpreadsheetVerticalAlign.Bottom:
                    return "bottom";
                case SpreadsheetVerticalAlign.Center:
                    return "center";
            }

            return value.ToString();
        }
    }
}

