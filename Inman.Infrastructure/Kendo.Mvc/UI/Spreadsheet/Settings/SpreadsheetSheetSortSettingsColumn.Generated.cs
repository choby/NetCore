using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetSheetSortSettingsColumn class
    /// </summary>
    public partial class SpreadsheetSheetSortSettingsColumn 
    {
        public bool? Ascending { get; set; }

        public double? Index { get; set; }


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Ascending.HasValue)
            {
                settings["ascending"] = Ascending;
            }

            if (Index.HasValue)
            {
                settings["index"] = Index;
            }

            return settings;
        }
    }
}
