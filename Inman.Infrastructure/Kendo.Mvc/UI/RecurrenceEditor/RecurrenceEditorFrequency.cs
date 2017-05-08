namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents the frequency types supported by Kendo UI RecurrenceEditor for ASP.NET MVC
    /// </summary>
    public enum RecurrenceEditorFrequency
    {
        Never,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    internal static class RecurrenceEditorFrequencyExtensions
    {
        internal static string Serialize(this RecurrenceEditorFrequency value)
        {
            switch (value)
            {
                case RecurrenceEditorFrequency.Never:
                    return "never";
                case RecurrenceEditorFrequency.Daily:
                    return "daily";
                case RecurrenceEditorFrequency.Weekly:
                    return "weekly";
                case RecurrenceEditorFrequency.Monthly:
                    return "monthly";
                case RecurrenceEditorFrequency.Yearly:
                    return "yearly";
            }

            return value.ToString();
        }
    }
}
