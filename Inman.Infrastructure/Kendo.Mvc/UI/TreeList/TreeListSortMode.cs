namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Defines the sort modes supported by Kendo UI TreeList for ASP.NET MVC
    /// </summary>
    public enum TreeListSortMode
    {
        /// <summary>
        /// The user can sort only by one column at the same time
        /// </summary>
        SingleColumn,
        /// <summary>
        /// The user can sort by more than one column at the same time
        /// </summary>
        MultipleColumn
    }

    internal static class TreeListSortModeExtensions
    {
        internal static string Serialize(this TreeListSortMode value)
        {
            switch (value)
            {
                case TreeListSortMode.SingleColumn:
                    return "single";
                case TreeListSortMode.MultipleColumn:
                    return "multiple";
            }

            return value.ToString();
        }
    }
}

