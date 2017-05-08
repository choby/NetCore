namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents the editing modes supported by Kendo UI TreeList for ASP.NET MVC
    /// </summary>
    public enum TreeListEditMode
    {
        /// <summary>
        /// Specifies in-line edit mode
        /// </summary>
        InLine,
        /// <summary>
        /// Specifies popup edit mode
        /// </summary>
        PopUp
    }

    internal static class TreeListEditModeExtensions
    {
        internal static string Serialize(this TreeListEditMode value)
        {
            switch (value)
            {
                case TreeListEditMode.InLine:
                    return "inline";
                case TreeListEditMode.PopUp:
                    return "popup";
            }

            return value.ToString();
        }
    }
}

