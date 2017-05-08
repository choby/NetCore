namespace Kendo.Mvc.UI
{
    public enum GaugeLinearPointerShape
    {
        /// <summary>
        /// Specifies a filling bar indicator.
        /// </summary>
        BarIndicator,
        /// <summary>
        /// Specifies an arrow shape.
        /// </summary>
        Arrow
    }

    internal static class GaugeLinearPointerShapeExtensions
    {
        internal static string Serialize(this GaugeLinearPointerShape value)
        {
            switch (value)
            {
                case GaugeLinearPointerShape.BarIndicator:
                    return "barIndicator";
                case GaugeLinearPointerShape.Arrow:
                    return "arrow";
            }

            return value.ToString();
        }
    }
}