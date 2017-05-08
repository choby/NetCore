namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents the Sortable widget Axis
    /// </summary>
    public enum SortableAxis
    {
        /// <summary>
        /// X axis
        /// </summary>
        X,
        /// <summary>
        /// Y axis
        /// </summary>
        Y,
        /// <summary>
        /// Default value
        /// </summary>
        None
    }

    internal static class SortableAxisExtensions
    {
        internal static string Serialize(this SortableAxis value)
        {
            switch (value)
            {
                case SortableAxis.X:
                    return "x";
                case SortableAxis.Y:
                    return "y";
                case SortableAxis.None:
                    return "0";
            }

            return value.ToString();
        }
    }
}

