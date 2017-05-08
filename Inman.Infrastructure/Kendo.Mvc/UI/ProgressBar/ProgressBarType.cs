namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Represents the supported progress types
    /// </summary>
    public enum ProgressBarType
    {
        /// <summary>
        /// 
        /// </summary>
        Value,
        /// <summary>
        /// 
        /// </summary>
        Percent,
        /// <summary>
        /// 
        /// </summary>
        Chunk
    }

    internal static class ProgressBarTypeExtensions
    {
        internal static string Serialize(this ProgressBarType value)
        {
            switch (value)
            {
                case ProgressBarType.Value:
                    return "value";
                case ProgressBarType.Percent:
                    return "percent";
                case ProgressBarType.Chunk:
                    return "chunk";
            }

            return value.ToString();
        }
    }
}

