using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Scheduler component
    /// </summary>
    public partial class Scheduler<T> where T : class, ISchedulerEvent 
    {
        public string AllDayEventTemplate { get; set; }

        public string AllDayEventTemplateId { get; set; }

        public bool? AllDaySlot { get; set; }

        public bool? AutoBind { get; set; }

        public SchedulerCurrentTimeMarkerSettings<T> CurrentTimeMarker { get; } = new SchedulerCurrentTimeMarkerSettings<T>();

        public DateTime? Date { get; set; }

        public string DateHeaderTemplate { get; set; }

        public string DateHeaderTemplateId { get; set; }

        public DateTime? EndTime { get; set; }

        public string EventTemplate { get; set; }

        public string EventTemplateId { get; set; }

        public SchedulerFooterSettings<T> Footer { get; } = new SchedulerFooterSettings<T>();

        public string GroupHeaderTemplate { get; set; }

        public string GroupHeaderTemplateId { get; set; }

        public double? Height { get; set; }

        public int? MajorTick { get; set; }

        public string MajorTimeHeaderTemplate { get; set; }

        public string MajorTimeHeaderTemplateId { get; set; }

        public DateTime? Max { get; set; }

        public SchedulerMessagesSettings<T> Messages { get; } = new SchedulerMessagesSettings<T>();

        public DateTime? Min { get; set; }

        public int? MinorTickCount { get; set; }

        public string MinorTimeHeaderTemplate { get; set; }

        public string MinorTimeHeaderTemplateId { get; set; }

        public SchedulerPdfSettings<T> Pdf { get; } = new SchedulerPdfSettings<T>();

        public bool? Selectable { get; set; }

        public bool? ShowWorkHours { get; set; }

        public bool? Snap { get; set; }

        public DateTime? StartTime { get; set; }

        public string Timezone { get; set; }

        public double? Width { get; set; }

        public DateTime? WorkDayStart { get; set; }

        public DateTime? WorkDayEnd { get; set; }

        public int? WorkWeekStart { get; set; }

        public int? WorkWeekEnd { get; set; }

        public MobileMode? Mobile { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (AllDayEventTemplateId.HasValue())
            {
                settings["allDayEventTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, AllDayEventTemplateId
                    )
                };
            }
            else if (AllDayEventTemplate.HasValue())
            {
                settings["allDayEventTemplate"] = AllDayEventTemplate;
            }

            if (AllDaySlot.HasValue)
            {
                settings["allDaySlot"] = AllDaySlot;
            }

            if (AutoBind.HasValue)
            {
                settings["autoBind"] = AutoBind;
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

            if (DateHeaderTemplateId.HasValue())
            {
                settings["dateHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, DateHeaderTemplateId
                    )
                };
            }
            else if (DateHeaderTemplate.HasValue())
            {
                settings["dateHeaderTemplate"] = DateHeaderTemplate;
            }

            if (EndTime.HasValue)
            {
                settings["endTime"] = EndTime;
            }

            if (EventTemplateId.HasValue())
            {
                settings["eventTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, EventTemplateId
                    )
                };
            }
            else if (EventTemplate.HasValue())
            {
                settings["eventTemplate"] = EventTemplate;
            }

            var footer = Footer.Serialize();
            if (footer.Any())
            {
                settings["footer"] = footer;
            }
            else if (Footer.Enabled.HasValue)
            {
                settings["footer"] = Footer.Enabled;
            }

            if (GroupHeaderTemplateId.HasValue())
            {
                settings["groupHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, GroupHeaderTemplateId
                    )
                };
            }
            else if (GroupHeaderTemplate.HasValue())
            {
                settings["groupHeaderTemplate"] = GroupHeaderTemplate;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            if (MajorTick.HasValue)
            {
                settings["majorTick"] = MajorTick;
            }

            if (MajorTimeHeaderTemplateId.HasValue())
            {
                settings["majorTimeHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, MajorTimeHeaderTemplateId
                    )
                };
            }
            else if (MajorTimeHeaderTemplate.HasValue())
            {
                settings["majorTimeHeaderTemplate"] = MajorTimeHeaderTemplate;
            }

            if (Max.HasValue)
            {
                settings["max"] = Max;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }

            if (Min.HasValue)
            {
                settings["min"] = Min;
            }

            if (MinorTickCount.HasValue)
            {
                settings["minorTickCount"] = MinorTickCount;
            }

            if (MinorTimeHeaderTemplateId.HasValue())
            {
                settings["minorTimeHeaderTemplate"] = new ClientHandlerDescriptor {
                    HandlerName = string.Format(
                        "jQuery('{0}{1}').html()", IdPrefix, MinorTimeHeaderTemplateId
                    )
                };
            }
            else if (MinorTimeHeaderTemplate.HasValue())
            {
                settings["minorTimeHeaderTemplate"] = MinorTimeHeaderTemplate;
            }

            var pdf = Pdf.Serialize();
            if (pdf.Any())
            {
                settings["pdf"] = pdf;
            }

            if (Selectable.HasValue)
            {
                settings["selectable"] = Selectable;
            }

            if (ShowWorkHours.HasValue)
            {
                settings["showWorkHours"] = ShowWorkHours;
            }

            if (Snap.HasValue)
            {
                settings["snap"] = Snap;
            }

            if (StartTime.HasValue)
            {
                settings["startTime"] = StartTime;
            }

            if (Timezone?.HasValue() == true)
            {
                settings["timezone"] = Timezone;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
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

            return settings;
        }
    }
}
