using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesEditorSettings class
    /// </summary>
    public partial class SchedulerMessagesEditorSettings<T> where T : class, ISchedulerEvent 
    {
        public string AllDayEvent { get; set; }

        public string Description { get; set; }

        public string EditorTitle { get; set; }

        public string End { get; set; }

        public string EndTimezone { get; set; }

        public string Repeat { get; set; }

        public string SeparateTimezones { get; set; }

        public string Start { get; set; }

        public string StartTimezone { get; set; }

        public string Timezone { get; set; }

        public string TimezoneEditorButton { get; set; }

        public string TimezoneEditorTitle { get; set; }

        public string Title { get; set; }


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AllDayEvent?.HasValue() == true)
            {
                settings["allDayEvent"] = AllDayEvent;
            }

            if (Description?.HasValue() == true)
            {
                settings["description"] = Description;
            }

            if (EditorTitle?.HasValue() == true)
            {
                settings["editorTitle"] = EditorTitle;
            }

            if (End?.HasValue() == true)
            {
                settings["end"] = End;
            }

            if (EndTimezone?.HasValue() == true)
            {
                settings["endTimezone"] = EndTimezone;
            }

            if (Repeat?.HasValue() == true)
            {
                settings["repeat"] = Repeat;
            }

            if (SeparateTimezones?.HasValue() == true)
            {
                settings["separateTimezones"] = SeparateTimezones;
            }

            if (Start?.HasValue() == true)
            {
                settings["start"] = Start;
            }

            if (StartTimezone?.HasValue() == true)
            {
                settings["startTimezone"] = StartTimezone;
            }

            if (Timezone?.HasValue() == true)
            {
                settings["timezone"] = Timezone;
            }

            if (TimezoneEditorButton?.HasValue() == true)
            {
                settings["timezoneEditorButton"] = TimezoneEditorButton;
            }

            if (TimezoneEditorTitle?.HasValue() == true)
            {
                settings["timezoneEditorTitle"] = TimezoneEditorTitle;
            }

            if (Title?.HasValue() == true)
            {
                settings["title"] = Title;
            }

            return settings;
        }
    }
}
