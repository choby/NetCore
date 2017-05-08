namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Specifies a QR code encoding mode.
    /// </summary>
    public enum QREncoding
    {
        /// <summary>
        /// Specifies the default encoding - ISO/IEC 8859-1.
        /// </summary>
        ISO_8859_1,
        /// <summary>
        /// Specifies a UTF-8 encoding.
        /// </summary>
        UTF_8
    }

    internal static class QREncodingExtensions
    {
        internal static string Serialize(this QREncoding value)
        {
            switch (value)
            {
                case QREncoding.ISO_8859_1:
                    return "ISO_8859_1";
                case QREncoding.UTF_8:
                    return "UTF_8";
            }

            return value.ToString();
        }
    }
}

