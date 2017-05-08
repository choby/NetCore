namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents the selection modes supported by Kendo UI ListView for ASP.NET MVC
    /// </summary>
    public enum ListViewSelectionMode
    {
        /// <summary>
        /// Single item selection.
        /// </summary>
        Single,
        /// <summary>
        /// Multiple item selection.
        /// </summary>
        Multiple
    }

    internal static class ListViewSelectionModeExtensions
    {
        internal static string Serialize(this ListViewSelectionMode value)
        {
            switch (value)
            {
                case ListViewSelectionMode.Single:
                    return "single";
                case ListViewSelectionMode.Multiple:
                    return "multiple";
            }

            return value.ToString();
        }
    }
}

