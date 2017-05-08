namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents available tag modes of MultiSelect.
    /// </summary>
    public enum MultiSelectTagMode
    {
        /// <summary>
        /// Renders a tag for each selected value
        /// </summary>
        Multiple,
        /// <summary>
        /// Renders a single tag
        /// </summary>
        Single
    }

    internal static class MultiSelectTagModeExtensions
    {
        internal static string Serialize(this MultiSelectTagMode value)
        {
            switch (value)
            {
                case MultiSelectTagMode.Multiple:
                    return "multiple";
                case MultiSelectTagMode.Single:
                    return "single";
            }

            return value.ToString();
        }
    }
}

