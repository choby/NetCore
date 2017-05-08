using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Grid component
    /// </summary>
    public partial class Grid<T> where T : class 
    {
        public GridAllowCopySettings<T> AllowCopy { get; } = new GridAllowCopySettings<T>();

        public bool? AutoBind { get; set; }

        public double? ColumnResizeHandleWidth { get; set; }

        public GridColumnMenuSettings<T> ColumnMenu { get; } = new GridColumnMenuSettings<T>();

        public GridExcelSettings<T> Excel { get; } = new GridExcelSettings<T>();

        public GridGroupableSettings<T> Groupable { get; } = new GridGroupableSettings<T>();

        public bool? Navigatable { get; set; }

        public GridNoRecordsSettings<T> NoRecords { get; } = new GridNoRecordsSettings<T>();

        public GridPdfSettings<T> Pdf { get; } = new GridPdfSettings<T>();

        public GridSortableSettings<T> Sortable { get; } = new GridSortableSettings<T>();


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            var allowCopy = AllowCopy.Serialize();
            if (allowCopy.Any())
            {
                settings["allowCopy"] = allowCopy;
            }
            else if (AllowCopy.Enabled.HasValue)
            {
                settings["allowCopy"] = AllowCopy.Enabled;
            }

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            if (ColumnResizeHandleWidth.HasValue)
            {
                settings["columnResizeHandleWidth"] = ColumnResizeHandleWidth;
            }

            var columnMenu = ColumnMenu.Serialize();
            if (columnMenu.Any())
            {
                settings["columnMenu"] = columnMenu;
            }
            else if (ColumnMenu.Enabled.HasValue)
            {
                settings["columnMenu"] = ColumnMenu.Enabled;
            }

            var excel = Excel.Serialize();
            if (excel.Any())
            {
                settings["excel"] = excel;
            }

            var groupable = Groupable.Serialize();
            if (groupable.Any())
            {
                settings["groupable"] = groupable;
            }
            else if (Groupable.Enabled.HasValue)
            {
                settings["groupable"] = Groupable.Enabled;
            }

            if (Navigatable.HasValue)
            {
                settings["navigatable"] = Navigatable;
            }

            var noRecords = NoRecords.Serialize();
            if (noRecords.Any())
            {
                settings["noRecords"] = noRecords;
            }
            else if (NoRecords.Enabled.HasValue)
            {
                settings["noRecords"] = NoRecords.Enabled;
            }

            var pdf = Pdf.Serialize();
            if (pdf.Any())
            {
                settings["pdf"] = pdf;
            }

            var sortable = Sortable.Serialize();
            if (sortable.Any())
            {
                settings["sortable"] = sortable;
            }
            else if (Sortable.Enabled.HasValue)
            {
                settings["sortable"] = Sortable.Enabled;
            }

            return settings;
        }
    }
}
