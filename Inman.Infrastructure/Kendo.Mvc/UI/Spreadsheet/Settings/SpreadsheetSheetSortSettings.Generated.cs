using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetSheetSortSettings class
    /// </summary>
    public partial class SpreadsheetSheetSortSettings 
    {
        public List<SpreadsheetSheetSortSettingsColumn> Columns { get; set; } = new List<SpreadsheetSheetSortSettingsColumn>();

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
