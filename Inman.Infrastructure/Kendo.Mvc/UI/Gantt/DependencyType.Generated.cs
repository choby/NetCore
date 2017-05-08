namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents the dependency types supported by Kendo UI Gantt for ASP.NET MVC.
    /// </summary>
    public enum DependencyType
    {
        /// <summary>
        /// The task cannot end before its predecessor task ends, although it may end later.
        /// </summary>
        FinishFinish,
        /// <summary>
        /// The task cannot start before its predecessor task ends, although it may start later.
        /// </summary>
        FinishStart,
        /// <summary>
        /// The task cannot end before its predecessor task starts, although it may end later.
        /// </summary>
        StartFinish,
        /// <summary>
        /// The task cannot start until the predecessor tasks starts, although it may start later.
        /// </summary>
        StartStart
    }

    internal static class DependencyTypeExtensions
    {
        internal static string Serialize(this DependencyType value)
        {
            switch (value)
            {
                case DependencyType.FinishFinish:
                    return "finishFinish";
                case DependencyType.FinishStart:
                    return "finishStart";
                case DependencyType.StartFinish:
                    return "startFinish";
                case DependencyType.StartStart:
                    return "startStart";
            }

            return value.ToString();
        }
    }
}

