using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Barcode component
    /// </summary>
    public partial class Barcode 
    {
        public RenderingMode? RenderAs { get; set; }

        public string Background { get; set; }

        public BarcodeBorderSettings Border { get; } = new BarcodeBorderSettings();

        public bool? Checksum { get; set; }

        public string Color { get; set; }

        public double? Height { get; set; }

        public BarcodePaddingSettings Padding { get; } = new BarcodePaddingSettings();

        public BarcodeTextSettings Text { get; } = new BarcodeTextSettings();

        public string Value { get; set; }

        public double? Width { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (RenderAs.HasValue)
            {
                settings["renderAs"] = RenderAs?.Serialize();
            }

            if (Background?.HasValue() == true)
            {
                settings["background"] = Background;
            }

            var border = Border.Serialize();
            if (border.Any())
            {
                settings["border"] = border;
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            var padding = Padding.Serialize();
            if (padding.Any())
            {
                settings["padding"] = padding;
            }

            var text = Text.Serialize();
            if (text.Any())
            {
                settings["text"] = text;
            }

            if (Value?.HasValue() == true)
            {
                settings["value"] = Value;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            return settings;
        }
    }
}
