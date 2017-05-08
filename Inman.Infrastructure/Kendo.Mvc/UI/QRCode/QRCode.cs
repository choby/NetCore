using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI QRCode component
    /// </summary>
    public partial class QRCode : WidgetBase
        
    {
        private const QRErrorCorrectionLevel DefaultErrorCorrection = QRErrorCorrectionLevel.L;
        private const QREncoding DefaultEncoding = QREncoding.ISO_8859_1;

        public QRCode(ViewContext viewContext) : base(viewContext)
        {
            this.ErrorCorrection = QRErrorCorrectionLevel.L;
            this.Encoding = QREncoding.ISO_8859_1;
        }

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.AddCssClass("k-qrcode");

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            if (ErrorCorrection.HasValue && ErrorCorrection.Value != DefaultErrorCorrection)
            {
                settings["errorCorrection"] = ErrorCorrection?.Serialize();
            }

            if (Encoding.HasValue && Encoding.Value != DefaultEncoding)
            {
                settings["encoding"] = Encoding?.Serialize();
            }

            writer.Write(Initializer.Initialize(Selector, "QRCode", settings));
        }
    }
}

