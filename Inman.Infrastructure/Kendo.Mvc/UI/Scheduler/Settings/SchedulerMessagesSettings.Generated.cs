using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI SchedulerMessagesSettings class
    /// </summary>
    public partial class SchedulerMessagesSettings<T> where T : class, ISchedulerEvent 
    {
        public string AllDay { get; set; }

        public string AriaEventLabel { get; set; }

        public string AriaSlotLabel { get; set; }

        public string Cancel { get; set; }

        public string Date { get; set; }

        public string DeleteWindowTitle { get; set; }

        public string Destroy { get; set; }

        public string Event { get; set; }

        public string DefaultRowText { get; set; }

        public string Pdf { get; set; }

        public string Save { get; set; }

        public string ShowFullDay { get; set; }

        public string ShowWorkDay { get; set; }

        public string Time { get; set; }

        public string Today { get; set; }

        public SchedulerMessagesEditableSettings<T> Editable { get; } = new SchedulerMessagesEditableSettings<T>();

        public SchedulerMessagesEditorSettings<T> Editor { get; } = new SchedulerMessagesEditorSettings<T>();

        public SchedulerMessagesRecurrenceEditorSettings<T> RecurrenceEditor { get; } = new SchedulerMessagesRecurrenceEditorSettings<T>();

        public SchedulerMessagesRecurrenceMessagesSettings<T> RecurrenceMessages { get; } = new SchedulerMessagesRecurrenceMessagesSettings<T>();

        public SchedulerMessagesViewsSettings<T> Views { get; } = new SchedulerMessagesViewsSettings<T>();


        public Scheduler<T> Scheduler { get; set; }

        protected Dictionary<string, object> SerializeSettings()
        {
            var settings = new Dictionary<string, object>();

            if (AllDay?.HasValue() == true)
            {
                settings["allDay"] = AllDay;
            }

            if (AriaEventLabel?.HasValue() == true)
            {
                settings["ariaEventLabel"] = AriaEventLabel;
            }

            if (AriaSlotLabel?.HasValue() == true)
            {
                settings["ariaSlotLabel"] = AriaSlotLabel;
            }

            if (Cancel?.HasValue() == true)
            {
                settings["cancel"] = Cancel;
            }

            if (Date?.HasValue() == true)
            {
                settings["date"] = Date;
            }

            if (DeleteWindowTitle?.HasValue() == true)
            {
                settings["deleteWindowTitle"] = DeleteWindowTitle;
            }

            if (Destroy?.HasValue() == true)
            {
                settings["destroy"] = Destroy;
            }

            if (Event?.HasValue() == true)
            {
                settings["event"] = Event;
            }

            if (DefaultRowText?.HasValue() == true)
            {
                settings["defaultRowText"] = DefaultRowText;
            }

            if (Pdf?.HasValue() == true)
            {
                settings["pdf"] = Pdf;
            }

            if (Save?.HasValue() == true)
            {
                settings["save"] = Save;
            }

            if (ShowFullDay?.HasValue() == true)
            {
                settings["showFullDay"] = ShowFullDay;
            }

            if (ShowWorkDay?.HasValue() == true)
            {
                settings["showWorkDay"] = ShowWorkDay;
            }

            if (Time?.HasValue() == true)
            {
                settings["time"] = Time;
            }

            if (Today?.HasValue() == true)
            {
                settings["today"] = Today;
            }

            var editable = Editable.Serialize();
            if (editable.Any())
            {
                settings["editable"] = editable;
            }

            var editor = Editor.Serialize();
            if (editor.Any())
            {
                settings["editor"] = editor;
            }

            var recurrenceEditor = RecurrenceEditor.Serialize();
            if (recurrenceEditor.Any())
            {
                settings["recurrenceEditor"] = recurrenceEditor;
            }

            var recurrenceMessages = RecurrenceMessages.Serialize();
            if (recurrenceMessages.Any())
            {
                settings["recurrenceMessages"] = recurrenceMessages;
            }

            var views = Views.Serialize();
            if (views.Any())
            {
                settings["views"] = views;
            }

            return settings;
        }
    }
}
