using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI PivotGrid component
    /// </summary>
    public partial class PivotGrid<T> where T : class 
    {
        public bool? AutoBind { get; set; }

        public bool? Reorderable { get; set; }

        public PivotGridExcelSettings<T> Excel { get; } = new PivotGridExcelSettings<T>();

        public PivotGridPdfSettings<T> Pdf { get; } = new PivotGridPdfSettings<T>();

        public bool? Filterable { get; set; }

        public PivotGridSortableSettings<T> Sortable { get; } = new PivotGridSortableSettings<T>();

        public double? ColumnWidth { get; set; }

        public double? Height { get; set; }

        public string ColumnHeaderTemplate { get; set; }

        public string ColumnHeaderTemplateId { get; set; }

        public string DataCellTemplate { get; set; }

        public string DataCellTemplateId { get; set; }

        public string RowHeaderTemplate { get; set; }

        public string RowHeaderTemplateId { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            if (Reorderable.HasValue)
            {
                settings["reorderable"] = Reorderable;
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

            if (Filterable.HasValue)
            {
                settings["filterable"] = Filterable;
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

            if (ColumnWidth.HasValue)
            {
                settings["columnWidth"] = ColumnWidth;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            if (ColumnHeaderTemplateId.HasValue())
            {
                settings["columnHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, ColumnHeaderTemplateId
                    )
                };
            }
            else if (ColumnHeaderTemplate.HasValue())
            {
                settings["columnHeaderTemplate"] = ColumnHeaderTemplate;
            }

            if (DataCellTemplateId.HasValue())
            {
                settings["dataCellTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, DataCellTemplateId
                    )
                };
            }
            else if (DataCellTemplate.HasValue())
            {
                settings["dataCellTemplate"] = DataCellTemplate;
            }

            if (RowHeaderTemplateId.HasValue())
            {
                settings["rowHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, RowHeaderTemplateId
                    )
                };
            }
            else if (RowHeaderTemplate.HasValue())
            {
                settings["rowHeaderTemplate"] = RowHeaderTemplate;
            }

            return settings;
        }
    }
}
