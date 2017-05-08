namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies where the icon of the button will be displayed. Applicable only for the children of a ButtonGroup.
    /// </summary>
    public enum ShowIn
    {
        Toolbar,
        Overflow,
        Both
    }

    internal static class ShowInExtensions
    {
        internal static string Serialize(this ShowIn value)
        {
            switch (value)
            {
                case ShowIn.Toolbar:
                    return "toolbar";
                case ShowIn.Overflow:
                    return "overflow";
                case ShowIn.Both:
                    return "both";
            }

            return value.ToString();
        }
    }
}

