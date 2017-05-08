namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies the gradient.
    /// </summary>
    public enum ChartBarGradient
    {
        /// <summary>
        /// The series have glass effect overlay.
        /// </summary>
        Glass,
        /// <summary>
        /// The series do not have grdient.
        /// </summary>
        None
    }

    internal static class ChartBarGradientExtensions
    {
        internal static string Serialize(this ChartBarGradient value)
        {
            switch (value)
            {
                case ChartBarGradient.Glass:
                    return "glass";
                case ChartBarGradient.None:
                    return "none";
            }

            return value.ToString();
        }
    }
}

