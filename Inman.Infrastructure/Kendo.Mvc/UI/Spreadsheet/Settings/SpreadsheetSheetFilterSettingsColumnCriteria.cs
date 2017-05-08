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
        public object Value { get; set; }

        public Dictionary<string, object> Serialize()
        {
            var settings = SerializeSettings();

            if (Value != null)
            {
                settings["value"] = Value;
            }

            return settings;
        }
    }
}
