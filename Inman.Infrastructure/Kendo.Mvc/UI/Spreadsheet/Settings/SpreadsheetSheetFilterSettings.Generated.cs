using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetSheetFilterSettings class
    /// </summary>
    public partial class SpreadsheetSheetFilterSettings 
    {
        public List<SpreadsheetSheetFilterSettingsColumn> Columns { get; set; } = new List<SpreadsheetSheetFilterSettingsColumn>();

        public string Ref { get; set; }


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var columns = Columns.Select(i => i.Serialize());
            if (columns.Any())
            {
                settings["columns"] = columns;
            }

            if (Ref?.HasValue() == true)
            {
                settings["ref"] = Ref;
            }

            return settings;
        }
    }
}
