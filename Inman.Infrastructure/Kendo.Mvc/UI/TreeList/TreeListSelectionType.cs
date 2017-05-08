namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies whether row or cell selection is allowed.
    /// </summary>
    public enum TreeListSelectionType
    {
        /// <summary>
        /// The user can select widget rows
        /// </summary>
        Row,
        /// <summary>
        /// The user can select widget cells
        /// </summary>
        Cell
    }

    internal static class TreeListSelectionTypeExtensions
    {
        internal static string Serialize(this TreeListSelectionType value)
        {
            switch (value)
            {
                case TreeListSelectionType.Row:
                    return "row";
                case TreeListSelectionType.Cell:
                    return "cell";
            }

            return value.ToString();
        }
    }
}

