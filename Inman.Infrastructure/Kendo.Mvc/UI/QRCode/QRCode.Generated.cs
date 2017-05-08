using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI QRCode component
    /// </summary>
    public partial class QRCode 
    {
        public string Background { get; set; }

        public QRCodeBorderSettings Border { get; } = new QRCodeBorderSettings();

        public string Color { get; set; }

        public double? Padding { get; set; }

        public RenderingMode? RenderAs { get; set; }

        public double? Size { get; set; }

        public string Value { get; set; }

        public QREncoding? Encoding { get; set; }

        public QRErrorCorrectionLevel? ErrorCorrection { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

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

            if (Padding.HasValue)
            {
                settings["padding"] = Padding;
            }

            if (RenderAs.HasValue)
            {
                settings["renderAs"] = RenderAs?.Serialize();
            }

            if (Size.HasValue)
            {
                settings["size"] = Size;
            }

            if (Value?.HasValue() == true)
            {
                settings["value"] = Value;
            }

            return settings;
        }
    }
}
