namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies how the button behaves when the ToolBar is resized.
    /// </summary>
    public enum ShowInOverflowPopup
    {
        Never,
        Always,
        Auto
    }

    internal static class ShowInOverflowPopupExtensions
    {
        internal static string Serialize(this ShowInOverflowPopup value)
        {
            switch (value)
            {
                case ShowInOverflowPopup.Never:
                    return "never";
                case ShowInOverflowPopup.Always:
                    return "always";
                case ShowInOverflowPopup.Auto:
                    return "auto";
            }

            return value.ToString();
        }
    }
}

