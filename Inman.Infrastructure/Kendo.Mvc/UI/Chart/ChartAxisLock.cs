namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies an axis that should not be panned or zoomed.
    /// </summary>
    public enum ChartAxisLock
    {
        /// <summary>
        /// No axis locking is applied.
        /// </summary>
        None,
        /// <summary>
        /// Locks the x axis.
        /// </summary>
        X,
        /// <summary>
        /// Locks the y axis.
        /// </summary>
        Y
    }

    internal static class ChartAxisLockExtensions
    {
        internal static string Serialize(this ChartAxisLock value)
        {
            switch (value)
            {
                case ChartAxisLock.None:
                    return "none";
                case ChartAxisLock.X:
                    return "x";
                case ChartAxisLock.Y:
                    return "y";
            }

            return value.ToString();
        }
    }
}

