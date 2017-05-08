using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetSheetFilterSettingsColumn class
    /// </summary>
    public partial class SpreadsheetSheetFilterSettingsColumn 
    {
        public List<SpreadsheetSheetFilterSettingsColumnCriteria> Criteria { get; set; } = new List<SpreadsheetSheetFilterSettingsColumnCriteria>();

        public string Filter { get; set; }

        public double? Index { get; set; }

        public string Logic { get; set; }

        public string Type { get; set; }

        public double? Value { get; set; }

        public object[] Values { get; set; }


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            var criteria = Criteria.Select(i => i.Serialize());
            if (criteria.Any())
            {
                settings["criteria"] = criteria;
            }

            if (Filter?.HasValue() == true)
            {
                settings["filter"] = Filter;
            }

            if (Index.HasValue)
            {
                settings["index"] = Index;
            }

            if (Logic?.HasValue() == true)
            {
                settings["logic"] = Logic;
            }

            if (Type?.HasValue() == true)
            {
                settings["type"] = Type;
            }

            if (Value.HasValue)
            {
                settings["value"] = Value;
            }

            if (Values?.Any() == true)
            {
                settings["values"] = Values;
            }

            return settings;
        }
    }
}
