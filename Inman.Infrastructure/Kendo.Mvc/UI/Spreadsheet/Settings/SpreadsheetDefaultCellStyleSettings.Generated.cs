using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetDefaultCellStyleSettings class
    /// </summary>
    public partial class SpreadsheetDefaultCellStyleSettings 
    {
        public string Background { get; set; }

        public string Color { get; set; }

        public string FontFamily { get; set; }

        public string FontSize { get; set; }

        public bool? Italic { get; set; }

        public bool? Bold { get; set; }

        public bool? Underline { get; set; }

        public bool? Wrap { get; set; }


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Background?.HasValue() == true)
            {
                settings["background"] = Background;
            }

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (FontFamily?.HasValue() == true)
            {
                settings["fontFamily"] = FontFamily;
            }

            if (FontSize?.HasValue() == true)
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

            if (Underline.HasValue)
            {
                settings["underline"] = Underline;
            }

            if (Wrap.HasValue)
            {
                settings["wrap"] = Wrap;
            }

            return settings;
        }
    }
}
