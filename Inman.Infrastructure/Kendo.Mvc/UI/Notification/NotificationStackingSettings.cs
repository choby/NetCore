namespace Kendo.Mvc.UI
{
    /// <summary>
    /// 
    /// </summary>
    public enum NotificationStackingSettings
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Up,
        /// <summary>
        /// 
        /// </summary>
        Down,
        /// <summary>
        /// 
        /// </summary>
        Left,
        /// <summary>
        /// 
        /// </summary>
        Right
    }

    internal static class NotificationStackingSettingsExtensions
    {
        internal static string Serialize(this NotificationStackingSettings value)
        {
            switch (value)
            {
                case NotificationStackingSettings.Default:
                    return "default";
                case NotificationStackingSettings.Up:
                    return "up";
                case NotificationStackingSettings.Down:
                    return "down";
                case NotificationStackingSettings.Left:
                    return "left";
                case NotificationStackingSettings.Right:
                    return "right";
            }

            return value.ToString();
        }
    }
}

