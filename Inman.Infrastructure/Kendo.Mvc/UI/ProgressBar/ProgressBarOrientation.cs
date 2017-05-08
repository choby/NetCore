namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Defines the orientation of the ProgressBar.
    /// </summary>
    public enum ProgressBarOrientation
    {
        /// <summary>
        /// Defines a vertical ProgressBar
        /// </summary>
        Vertical,
        /// <summary>
        /// Defines a horizontal ProgressBar
        /// </summary>
        Horizontal
    }

    internal static class ProgressBarOrientationExtensions
    {
        internal static string Serialize(this ProgressBarOrientation value)
        {
            switch (value)
            {
                case ProgressBarOrientation.Vertical:
                    return "vertical";
                case ProgressBarOrientation.Horizontal:
                    return "horizontal";
            }

            return value.ToString();
        }
    }
}

