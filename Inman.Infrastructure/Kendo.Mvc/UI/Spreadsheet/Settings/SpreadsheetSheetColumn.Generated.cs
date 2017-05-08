using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetSheetColumn class
    /// </summary>
    public partial class SpreadsheetSheetColumn 
    {
        public int? Index { get; set; }

        public double? Width { get; set; }


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Index.HasValue)
            {
                settings["index"] = Index;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            return settings;
        }
    }
}
