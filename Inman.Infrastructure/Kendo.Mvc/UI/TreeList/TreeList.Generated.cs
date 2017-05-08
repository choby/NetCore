using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI TreeList component
    /// </summary>
    public partial class TreeList<T> where T : class 
    {
        public bool? AutoBind { get; set; }

        public List<TreeListColumn<T>> Columns { get; set; } = new List<TreeListColumn<T>>();

        public bool? Resizable { get; set; }

        public bool? Reorderable { get; set; }

        public TreeListColumnMenuSettings<T> ColumnMenu { get; } = new TreeListColumnMenuSettings<T>();

        public TreeListEditableSettings<T> Editable { get; } = new TreeListEditableSettings<T>();

        public TreeListExcelSettings<T> Excel { get; } = new TreeListExcelSettings<T>();

        public TreeListFilterableSettings<T> Filterable { get; } = new TreeListFilterableSettings<T>();

        public double? Height { get; set; }

        public TreeListMessagesSettings<T> Messages { get; } = new TreeListMessagesSettings<T>();

        public TreeListPdfSettings<T> Pdf { get; } = new TreeListPdfSettings<T>();

        public bool? Scrollable { get; set; }

        public TreeListSortableSettings<T> Sortable { get; } = new TreeListSortableSettings<T>();

        public List<TreeListToolbar<T>> Toolbar { get; set; } = new List<TreeListToolbar<T>>();

        public TreeListSelectableSettings<T> Selectable { get; } = new TreeListSelectableSettings<T>();


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            var columns = Columns.Select(i => i.Serialize());
            if (columns.Any())
            {
                settings["columns"] = columns;
            }

            if (Resizable.HasValue)
            {
                settings["resizable"] = Resizable;
            }

            if (Reorderable.HasValue)
            {
                settings["reorderable"] = Reorderable;
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

            var editable = Editable.Serialize();
            if (editable.Any())
            {
                settings["editable"] = editable;
            }
            else if (Editable.Enabled.HasValue)
            {
                settings["editable"] = Editable.Enabled;
            }

            var excel = Excel.Serialize();
            if (excel.Any())
            {
                settings["excel"] = excel;
            }

            var filterable = Filterable.Serialize();
            if (filterable.Any())
            {
                settings["filterable"] = filterable;
            }
            else if (Filterable.Enabled.HasValue)
            {
                settings["filterable"] = Filterable.Enabled;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }

            var pdf = Pdf.Serialize();
            if (pdf.Any())
            {
                settings["pdf"] = pdf;
            }

            if (Scrollable.HasValue)
            {
                settings["scrollable"] = Scrollable;
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

            var toolbar = Toolbar.Select(i => i.Serialize());
            if (toolbar.Any())
            {
                settings["toolbar"] = toolbar;
            }


            return settings;
        }
    }
}
