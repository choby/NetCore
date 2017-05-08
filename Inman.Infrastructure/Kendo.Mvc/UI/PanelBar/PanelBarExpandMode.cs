namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies how the PanelBar items are displayed when opened and closed.
    /// </summary>
    public enum PanelBarExpandMode
    {
        /// <summary>
        /// Display one item at a time
        /// </summary>
        Single,
        /// <summary>
        /// Display multiple items at a time
        /// </summary>
        Multiple
    }

    internal static class PanelBarExpandModeExtensions
    {
        internal static string Serialize(this PanelBarExpandMode value)
        {
            switch (value)
            {
                case PanelBarExpandMode.Single:
                    return "single";
                case PanelBarExpandMode.Multiple:
                    return "multiple";
            }

            return value.ToString();
        }
    }
}

