using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetSheetRowCell class
    /// </summary>
    public partial class SpreadsheetSheetRowCell 
    {
        public string Background { get; set; }

        public SpreadsheetSheetRowCellBorderBottomSettings BorderBottom { get; } = new SpreadsheetSheetRowCellBorderBottomSettings();

        public SpreadsheetSheetRowCellBorderLeftSettings BorderLeft { get; } = new SpreadsheetSheetRowCellBorderLeftSettings();

        public SpreadsheetSheetRowCellBorderTopSettings BorderTop { get; } = new SpreadsheetSheetRowCellBorderTopSettings();

        public SpreadsheetSheetRowCellBorderRightSettings BorderRight { get; } = new SpreadsheetSheetRowCellBorderRightSettings();

        public string Color { get; set; }

        public string FontFamily { get; set; }

        public double? FontSize { get; set; }

        public bool? Italic { get; set; }

        public bool? Bold { get; set; }

        public bool? Enable { get; set; }

        public string Format { get; set; }

        public string Formula { get; set; }

        public int? Index { get; set; }

        public string Link { get; set; }

        public bool? Underline { get; set; }

        public object Value { get; set; }

        public SpreadsheetSheetRowCellValidationSettings Validation { get; } = new SpreadsheetSheetRowCellValidationSettings();

        public bool? Wrap { get; set; }

        public SpreadsheetTextAlign? TextAlign { get; set; }

        public SpreadsheetVerticalAlign? VerticalAlign { get; set; }


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Background?.HasValue() == true)
            {
                settings["background"] = Background;
            }

            var borderBottom = BorderBottom.Serialize();
            if (borderBottom.Any())
            {
                settings["borderBottom"] = borderBottom;
            }

            var borderLeft = BorderLeft.Serialize();
            if (borderLeft.Any())
            {
                settings["borderLeft"] = borderLeft;
            }

            var borderTop = BorderTop.Serialize();
            if (borderTop.Any())
            {
                settings["borderTop"] = borderTop;
            }

            var borderRight = BorderRight.Serialize();
            if (borderRight.Any())
            {
                settings["borderRight"] = borderRight;
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (FontFamily?.HasValue() == true)
            {
                settings["fontFamily"] = FontFamily;
            }

            if (FontSize.HasValue)
            {
                settings["fontSize"] = FontSize;
            }

            if (Italic.HasValue)
            {
                settings["italic"] = Italic;
            }

            if (Bold.HasValue)
            {
                settings["bold"] = Bold;
            }

            if (Enable.HasValue)
            {
                settings["enable"] = Enable;
            }

            if (Format?.HasValue() == true)
            {
                settings["format"] = Format;
            }

            if (Formula?.HasValue() == true)
            {
                settings["formula"] = Formula;
            }

            if (Index.HasValue)
            {
                settings["index"] = Index;
            }

            if (Link?.HasValue() == true)
            {
                settings["link"] = Link;
            }

            if (Underline.HasValue)
            {
                settings["underline"] = Underline;
            }

            if (Value != null)
            {
                settings["value"] = Value;
            }

            var validation = Validation.Serialize();
            if (validation.Any())
            {
                settings["validation"] = validation;
            }

            if (Wrap.HasValue)
            {
                settings["wrap"] = Wrap;
            }

            if (TextAlign.HasValue)
            {
                settings["textAlign"] = TextAlign?.Serialize();
            }

            if (VerticalAlign.HasValue)
            {
                settings["verticalAlign"] = VerticalAlign?.Serialize();
            }

            return settings;
        }
    }
}
