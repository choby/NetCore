namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the key that should be pressed to activate panning or zooming.
    /// </summary>
    public enum ChartActivationKey
    {
        /// <summary>
        /// No key is required.
        /// </summary>
        None,
        /// <summary>
        /// The "ctrl" key should be pressed.
        /// </summary>
        Ctrl,
        /// <summary>
        /// The "shift" key should be pressed.
        /// </summary>
        Shift,
        /// <summary>
        /// The "alt" key should be pressed.
        /// </summary>
        Alt
    }

    internal static class ChartActivationKeyExtensions
    {
        internal static string Serialize(this ChartActivationKey value)
        {
            switch (value)
            {
                case ChartActivationKey.None:
                    return "none";
                case ChartActivationKey.Ctrl:
                    return "ctrl";
                case ChartActivationKey.Shift:
                    return "shift";
                case ChartActivationKey.Alt:
                    return "alt";
            }

            return value.ToString();
        }
    }
}

