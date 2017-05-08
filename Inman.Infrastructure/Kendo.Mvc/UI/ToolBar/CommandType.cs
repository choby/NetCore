namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the type of the item.
    /// </summary>
    public enum CommandType
    {
        Button,
        SplitButton,
        ButtonGroup,
        Separator
    }

    internal static class CommandTypeExtensions
    {
        internal static string Serialize(this CommandType value)
        {
            switch (value)
            {
                case CommandType.Button:
                    return "button";
                case CommandType.SplitButton:
                    return "splitButton";
                case CommandType.ButtonGroup:
                    return "buttonGroup";
                case CommandType.Separator:
                    return "separator";
            }

            return value.ToString();
        }
    }
}

