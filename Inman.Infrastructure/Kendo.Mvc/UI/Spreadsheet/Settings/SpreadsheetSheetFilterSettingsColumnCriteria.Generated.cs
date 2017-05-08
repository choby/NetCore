using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetSheetFilterSettingsColumnCriteria class
    /// </summary>
    public partial class SpreadsheetSheetFilterSettingsColumnCriteria 
    {
        public SpreadsheetFilterOperator? Operator { get; set; }


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Operator.HasValue)
            {
                settings["operator"] = Operator?.Serialize();
            }

            return settings;
        }
    }
}
