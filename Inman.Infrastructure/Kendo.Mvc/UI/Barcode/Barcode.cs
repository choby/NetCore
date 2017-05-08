using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.IO;
using Kendo.Mvc.Resources;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Barcode component
    /// </summary>
    public partial class Barcode : WidgetBase
        
    {
        public Barcode(ViewContext viewContext) : base(viewContext)
        {
            this.Encoding = BarcodeSymbology.Code128;
            this.Text = new BarcodeTextSettings();
            this.Text.Visible = true;
        }

        public BarcodeSymbology Encoding { get; set; }

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.AddCssClass("k-barcode");

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            settings["type"] = this.Encoding;

            if (this.Encoding == BarcodeSymbology.GS1128)
            {
                settings["type"] = "gs1-128";
            }
            if (Checksum.HasValue && Checksum.Value == false)
            {
                settings["checksum"] = Checksum;
            }


            writer.Write(Initializer.Initialize(Selector, "Barcode", settings));
        }

        public override void VerifySettings()
        {
            base.VerifySettings();

            if (String.IsNullOrEmpty(Value))
            {
                throw new ArgumentException(Exceptions.CannotBeNullOrEmpty.FormatWith("Value"));
            }

            if (this.Encoding == BarcodeSymbology.EAN8 && this.Value.Length != 7)
            {
                throw new ArgumentException(Exceptions.ValueNotValidForProperty.FormatWith("Value"));
            }

            //TODO ADD VALIDATION FOR ALL ENCODINGS
        }
    }
}

