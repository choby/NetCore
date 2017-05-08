using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Dialog component
    /// </summary>
    public partial class Dialog : WidgetBase
        
    {
        public Dialog(ViewContext viewContext) : base(viewContext)
        {
        }

        public PopupAnimation Animation { get; } = new PopupAnimation();

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            var animation = Animation.ToJson();

            if (animation.Any())
            {
                if (animation["animation"] is bool)
                {
                    settings["animation"] = false;
                }
                else
                {
                    settings["animation"] = animation["animation"];
                }
            }

            // TODO: Manually serialized settings go here

            writer.Write(Initializer.Initialize(Selector, "Dialog", settings));
        }
    }
}

