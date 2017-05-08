using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Dialog component
    /// </summary>
    public partial class Dialog 
    {
        public List<DialogAction> Actions { get; set; } = new List<DialogAction>();

        public string ButtonLayout { get; set; }

        public bool? Closable { get; set; }

        public double? Height { get; set; }

        public double? MaxHeight { get; set; }

        public double? MaxWidth { get; set; }

        public DialogMessagesSettings Messages { get; } = new DialogMessagesSettings();

        public double? MinHeight { get; set; }

        public double? MinWidth { get; set; }

        public bool? Modal { get; set; }

        public string Title { get; set; }

        public bool? Visible { get; set; }

        public double? Width { get; set; }

        public string Content { get; set; }


        protected override Dictionary<string, object> SerializeSettings()
        {
            var settings = base.SerializeSettings();

            var actions = Actions.Select(i => i.Serialize());
            if (actions.Any())
            {
                settings["actions"] = actions;
            }

            if (ButtonLayout?.HasValue() == true)
            {
                settings["buttonLayout"] = ButtonLayout;
            }

            if (Closable.HasValue)
            {
                settings["closable"] = Closable;
            }

            if (Height.HasValue)
            {
                settings["height"] = Height;
            }

            if (MaxHeight.HasValue)
            {
                settings["maxHeight"] = MaxHeight;
            }

            if (MaxWidth.HasValue)
            {
                settings["maxWidth"] = MaxWidth;
            }

            var messages = Messages.Serialize();
            if (messages.Any())
            {
                settings["messages"] = messages;
            }

            if (MinHeight.HasValue)
            {
                settings["minHeight"] = MinHeight;
            }

            if (MinWidth.HasValue)
            {
                settings["minWidth"] = MinWidth;
            }

            if (Modal.HasValue)
            {
                settings["modal"] = Modal;
            }

            if (Title?.HasValue() == true)
            {
                settings["title"] = Title;
            }

            if (Visible.HasValue)
            {
                settings["visible"] = Visible;
            }

            if (Width.HasValue)
            {
                settings["width"] = Width;
            }

            if (Content?.HasValue() == true)
            {
                settings["content"] = Content;
            }

            return settings;
        }
    }
}
