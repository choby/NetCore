using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RecurrenceEditor component
    /// </summary>
    public class RecurrenceEditor : WidgetBase
    {
        public RecurrenceEditor(ViewContext viewContext)
            : base(viewContext)
        {
            Frequencies = new List<RecurrenceEditorFrequency>();

            FirstWeekDay = 0;

            Messages = new SchedulerMessagesRecurrenceEditorSettings<ISchedulerEvent>();
        }

        public DateTime? Start
        {
            get;
            set;
        }

        public int FirstWeekDay
        {
            get;
            set;
        }

        public string Timezone
        {
            get;
            set;
        }

        public string Value
        {
            get;
            set;
        }

        public SchedulerMessagesRecurrenceEditorSettings<ISchedulerEvent> Messages
        {
            get;
            private set;
        }

        public IList<RecurrenceEditorFrequency> Frequencies
        {
            get;
            private set;
        }

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            writer.Write(Initializer.Initialize(Selector, "RecurrenceEditor", settings));
        }

        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            if (Start.HasValue)
            {
                settings["start"] = Start;
            }

            if (FirstWeekDay != 0)
            {
                settings["firstWeekDay"] = FirstWeekDay;
            }

            if (Timezone?.HasValue() == true)
            {
                settings["timezone"] = Timezone;
            }

            if (Value?.HasValue() == true)
            {
                settings["value"] = Value;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }

            var frequencies = Frequencies.Select(f => f.Serialize());
            if (frequencies.Any())
            {
                settings["frequencies"] = frequencies;
            }

            return settings;
        }
    }
}
