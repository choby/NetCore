using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SpreadsheetSheet class
    /// </summary>
    public partial class SpreadsheetSheet 
    {
        public string ActiveCell { get; set; }

        public string Name { get; set; }

        public List<SpreadsheetSheetColumn> Columns { get; set; } = new List<SpreadsheetSheetColumn>();

        public SpreadsheetSheetFilterSettings Filter { get; } = new SpreadsheetSheetFilterSettings();

        public int? FrozenColumns { get; set; }

        public int? FrozenRows { get; set; }

        public string[] MergedCells { get; set; }

        public List<SpreadsheetSheetRow> Rows { get; set; } = new List<SpreadsheetSheetRow>();

        public string Selection { get; set; }

        public bool? ShowGridLines { get; set; }

        public SpreadsheetSheetSortSettings Sort { get; } = new SpreadsheetSheetSortSettings();


        public Spreadsheet Spreadsheet { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (ActiveCell?.HasValue() == true)
            {
                settings["activeCell"] = ActiveCell;
            }

            if (Name?.HasValue() == true)
            {
                settings["name"] = Name;
            }

            var columns = Columns.Select(i => i.Serialize());
            if (columns.Any())
            {
                settings["columns"] = columns;
            }

            var filter = Filter.Serialize();
            if (filter.Any())
            {
                settings["filter"] = filter;
            }

            if (FrozenColumns.HasValue)
            {
                settings["frozenColumns"] = FrozenColumns;
            }

            if (FrozenRows.HasValue)
            {
                settings["frozenRows"] = FrozenRows;
            }

            if (MergedCells?.Any() == true)
            {
                settings["mergedCells"] = MergedCells;
            }

            var rows = Rows.Select(i => i.Serialize());
            if (rows.Any())
            {
                settings["rows"] = rows;
            }

            if (Selection?.HasValue() == true)
            {
                settings["selection"] = Selection;
            }

            if (ShowGridLines.HasValue)
            {
                settings["showGridLines"] = ShowGridLines;
            }

            var sort = Sort.Serialize();
            if (sort.Any())
            {
                settings["sort"] = sort;
            }

            return settings;
        }
    }
}
