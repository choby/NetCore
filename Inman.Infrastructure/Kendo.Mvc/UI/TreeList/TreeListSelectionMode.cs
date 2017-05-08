namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies whether multiple or single selection is allowed.
    /// </summary>
    public enum TreeListSelectionMode
    {
        /// <summary>
        /// The user can select only by one item at the same time
        /// </summary>
        Single,
        /// <summary>
        /// The user can select by more than one item at the same time
        /// </summary>
        Multiple
    }

    internal static class TreeListSelectionModeExtensions
    {
        internal static string Serialize(this TreeListSelectionMode value)
        {
            switch (value)
            {
                case TreeListSelectionMode.Single:
                    return "single";
                case TreeListSelectionMode.Multiple:
                    return "multiple";
            }

            return value.ToString();
        }
    }
}

