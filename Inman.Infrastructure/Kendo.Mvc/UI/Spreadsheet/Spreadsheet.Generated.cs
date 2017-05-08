using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Spreadsheet component
    /// </summary>
    public partial class Spreadsheet 
    {
        public string ActiveSheet { get; set; }

        public double? ColumnWidth { get; set; }

        public double? Columns { get; set; }

        public SpreadsheetDefaultCellStyleSettings DefaultCellStyle { get; } = new SpreadsheetDefaultCellStyleSettings();

        public double? HeaderHeight { get; set; }

        public double? HeaderWidth { get; set; }

        public SpreadsheetExcelSettings Excel { get; } = new SpreadsheetExcelSettings();

        public SpreadsheetPdfSettings Pdf { get; } = new SpreadsheetPdfSettings();

        public double? RowHeight { get; set; }

        public double? Rows { get; set; }

        public List<SpreadsheetSheet> Sheets { get; set; } = new List<SpreadsheetSheet>();

        public bool? Sheetsbar { get; set; }

        public SpreadsheetToolbarSettings Toolbar { get; } = new SpreadsheetToolbarSettings();


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (ActiveSheet?.HasValue() == true)
            {
                settings["activeSheet"] = ActiveSheet;
            }

            if (ColumnWidth.HasValue)
            {
                settings["columnWidth"] = ColumnWidth;
            }

            if (Columns.HasValue)
            {
                settings["columns"] = Columns;
            }

            var defaultCellStyle = DefaultCellStyle.Serialize();
            if (defaultCellStyle.Any())
            {
                settings["defaultCellStyle"] = defaultCellStyle;
            }

            if (HeaderHeight.HasValue)
            {
                settings["headerHeight"] = HeaderHeight;
            }

            if (HeaderWidth.HasValue)
            {
                settings["headerWidth"] = HeaderWidth;
            }

            var excel = Excel.Serialize();
            if (excel.Any())
            {
                settings["excel"] = excel;
            }

            var pdf = Pdf.Serialize();
            if (pdf.Any())
            {
                settings["pdf"] = pdf;
            }

            if (RowHeight.HasValue)
            {
                settings["rowHeight"] = RowHeight;
            }

            if (Rows.HasValue)
            {
                settings["rows"] = Rows;
            }

            var sheets = Sheets.Select(i => i.Serialize());
            if (sheets.Any())
            {
                settings["sheets"] = sheets;
            }

            if (Sheetsbar.HasValue)
            {
                settings["sheetsbar"] = Sheetsbar;
            }

            var toolbar = Toolbar.Serialize();
            if (toolbar.Any())
            {
                settings["toolbar"] = toolbar;
            }
            else if (Toolbar.Enabled.HasValue)
            {
                settings["toolbar"] = Toolbar.Enabled;
            }

            return settings;
        }
    }
}
