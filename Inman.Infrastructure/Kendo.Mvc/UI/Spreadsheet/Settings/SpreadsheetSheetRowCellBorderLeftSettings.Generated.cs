using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetSheetRowCellBorderLeftSettings class
    /// </summary>
    public partial class SpreadsheetSheetRowCellBorderLeftSettings 
    {
        public string Color { get; set; }

        public string Size { get; set; }


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Color?.HasValue() == true)
            {
                settings["color"] = Color;
            }

            if (Size?.HasValue() == true)
            {
                settings["size"] = Size;
            }

            return settings;
        }
    }
}
