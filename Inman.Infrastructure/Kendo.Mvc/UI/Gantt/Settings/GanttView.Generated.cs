using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI GanttView class
    /// </summary>
    public partial class GanttView<TTaskModel, TDependenciesModel> where TTaskModel : class, IGanttTask  where TDependenciesModel : class, IGanttDependency 
    {
        public DateTime? Date { get; set; }

        public GanttViewRangeSettings<TTaskModel, TDependenciesModel> Range { get; } = new GanttViewRangeSettings<TTaskModel, TDependenciesModel>();

        public bool? Selected { get; set; }

        public double? SlotSize { get; set; }

        public string TimeHeaderTemplate { get; set; }

        public string TimeHeaderTemplateId { get; set; }

        public string DayHeaderTemplate { get; set; }

        public string DayHeaderTemplateId { get; set; }

        public string WeekHeaderTemplate { get; set; }

        public string WeekHeaderTemplateId { get; set; }

        public string MonthHeaderTemplate { get; set; }

        public string MonthHeaderTemplateId { get; set; }

        public string YearHeaderTemplate { get; set; }

        public string YearHeaderTemplateId { get; set; }

        public string ResizeTooltipFormat { get; set; }

        public GanttViewType? Type { get; set; }


        public Gantt<TTaskModel, TDependenciesModel> Gantt { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (Date.HasValue)
            {
                settings["date"] = Date;
            }

            var range = Range.Serialize();
            if (range.Any())
            {
                settings["range"] = range;
            }

            if (Selected.HasValue)
            {
                settings["selected"] = Selected;
            }

            if (SlotSize.HasValue)
            {
                settings["slotSize"] = SlotSize;
            }

            if (TimeHeaderTemplateId.HasValue())
            {
                settings["timeHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Gantt.IdPrefix, TimeHeaderTemplateId
                    )
                };
            }
            else if (TimeHeaderTemplate.HasValue())
            {
                settings["timeHeaderTemplate"] = TimeHeaderTemplate;
            }

            if (DayHeaderTemplateId.HasValue())
            {
                settings["dayHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Gantt.IdPrefix, DayHeaderTemplateId
                    )
                };
            }
            else if (DayHeaderTemplate.HasValue())
            {
                settings["dayHeaderTemplate"] = DayHeaderTemplate;
            }

            if (WeekHeaderTemplateId.HasValue())
            {
                settings["weekHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Gantt.IdPrefix, WeekHeaderTemplateId
                    )
                };
            }
            else if (WeekHeaderTemplate.HasValue())
            {
                settings["weekHeaderTemplate"] = WeekHeaderTemplate;
            }

            if (MonthHeaderTemplateId.HasValue())
            {
                settings["monthHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Gantt.IdPrefix, MonthHeaderTemplateId
                    )
                };
            }
            else if (MonthHeaderTemplate.HasValue())
            {
                settings["monthHeaderTemplate"] = MonthHeaderTemplate;
            }

            if (YearHeaderTemplateId.HasValue())
            {
                settings["yearHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", Gantt.IdPrefix, YearHeaderTemplateId
                    )
                };
            }
            else if (YearHeaderTemplate.HasValue())
            {
                settings["yearHeaderTemplate"] = YearHeaderTemplate;
            }

            if (ResizeTooltipFormat?.HasValue() == true)
            {
                settings["resizeTooltipFormat"] = ResizeTooltipFormat;
            }

            if (Type.HasValue)
            {
                settings["type"] = Type?.Serialize();
            }

            return settings;
        }
    }
}
