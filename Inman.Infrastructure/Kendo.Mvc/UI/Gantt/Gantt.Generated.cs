using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Gantt component
    /// </summary>
    public partial class Gantt<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public bool? AutoBind { get; set; }

        public double? ColumnResizeHandleWidth { get; set; }

        public List<GanttColumn<TTaskModel, TDependenciesModel>> Columns { get; set; } = new List<GanttColumn<TTaskModel, TDependenciesModel>>();

        public GanttCurrentTimeMarkerSettings<TTaskModel, TDependenciesModel> CurrentTimeMarker { get; } = new GanttCurrentTimeMarkerSettings<TTaskModel, TDependenciesModel>();

        public DateTime? Date { get; set; }

        public GanttEditableSettings<TTaskModel, TDependenciesModel> Editable { get; } = new GanttEditableSettings<TTaskModel, TDependenciesModel>();

        public bool? Navigatable { get; set; }

        public DateTime? WorkDayStart { get; set; }

        public DateTime? WorkDayEnd { get; set; }

        public double? WorkWeekStart { get; set; }

        public double? WorkWeekEnd { get; set; }

        public double? HourSpan { get; set; }

        public bool? Snap { get; set; }

        public double? Height { get; set; }

        public string ListWidth { get; set; }

        public GanttMessagesSettings<TTaskModel, TDependenciesModel> Messages { get; } = new GanttMessagesSettings<TTaskModel, TDependenciesModel>();

        public GanttPdfSettings<TTaskModel, TDependenciesModel> Pdf { get; } = new GanttPdfSettings<TTaskModel, TDependenciesModel>();

        public GanttRangeSettings<TTaskModel, TDependenciesModel> Range { get; } = new GanttRangeSettings<TTaskModel, TDependenciesModel>();

        public bool? Resizable { get; set; }

        public bool? Selectable { get; set; }

        public bool? ShowWorkDays { get; set; }

        public bool? ShowWorkHours { get; set; }

        public string TaskTemplate { get; set; }

        public string TaskTemplateId { get; set; }

        public List<GanttToolbar<TTaskModel, TDependenciesModel>> Toolbar { get; set; } = new List<GanttToolbar<TTaskModel, TDependenciesModel>>();

        public GanttTooltipSettings<TTaskModel, TDependenciesModel> Tooltip { get; } = new GanttTooltipSettings<TTaskModel, TDependenciesModel>();

        public List<GanttView<TTaskModel, TDependenciesModel>> Views { get; set; } = new List<GanttView<TTaskModel, TDependenciesModel>>();

        public double? RowHeight { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
            }

            if (ColumnResizeHandleWidth.HasValue)
            {
                settings["columnResizeHandleWidth"] = ColumnResizeHandleWidth;
            }

            var columns = Columns.Select(i => i.Serialize());
            if (columns.Any())
            {
                settings["columns"] = columns;
            }

            var currentTimeMarker = CurrentTimeMarker.Serialize();
            if (currentTimeMarker.Any())
            {
                settings["currentTimeMarker"] = currentTimeMarker;
            }
            else if (CurrentTimeMarker.Enabled.HasValue)
            {
                settings["currentTimeMarker"] = CurrentTimeMarker.Enabled;
            }

            if (Date.HasValue)
            {
                settings["date"] = Date;
            }


            if (Navigatable.HasValue)
            {
                settings["navigatable"] = Navigatable;
            }

            if (WorkDayStart.HasValue)
            {
                settings["workDayStart"] = WorkDayStart;
            }

            if (WorkDayEnd.HasValue)
            {
                settings["workDayEnd"] = WorkDayEnd;
            }

            if (WorkWeekStart.HasValue)
            {
                settings["workWeekStart"] = WorkWeekStart;
            }

            if (WorkWeekEnd.HasValue)
            {
                settings["workWeekEnd"] = WorkWeekEnd;
            }

            if (HourSpan.HasValue)
            {
                settings["hourSpan"] = HourSpan;
            }

            if (Snap.HasValue)
            {
                settings["snap"] = Snap;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            if (ListWidth?.HasValue() == true)
            {
                settings["listWidth"] = ListWidth;
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

            var range = Range.Serialize();
            if (range.Any())
            {
                settings["range"] = range;
            }

            if (Resizable.HasValue)
            {
                settings["resizable"] = Resizable;
            }

            if (Selectable.HasValue)
            {
                settings["selectable"] = Selectable;
            }

            if (ShowWorkDays.HasValue)
            {
                settings["showWorkDays"] = ShowWorkDays;
            }

            if (ShowWorkHours.HasValue)
            {
                settings["showWorkHours"] = ShowWorkHours;
            }

            if (TaskTemplateId.HasValue())
            {
                settings["taskTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, TaskTemplateId
                    )
                };
            }
            else if (TaskTemplate.HasValue())
            {
                settings["taskTemplate"] = TaskTemplate;
            }

            var toolbar = Toolbar.Select(i => i.Serialize());
            if (toolbar.Any())
            {
                settings["toolbar"] = toolbar;
            }

            var tooltip = Tooltip.Serialize();
            if (tooltip.Any())
            {
                settings["tooltip"] = tooltip;
            }

            var views = Views.Select(i => i.Serialize());
            if (views.Any())
            {
                settings["views"] = views;
            }

            if (RowHeight.HasValue)
            {
                settings["rowHeight"] = RowHeight;
            }

            return settings;
        }
    }
}
