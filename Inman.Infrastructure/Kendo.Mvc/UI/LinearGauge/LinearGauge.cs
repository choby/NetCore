using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI LinearGauge component
    /// </summary>
    public partial class LinearGauge : WidgetBase
        
    {
        public LinearGauge(ViewContext viewContext) : base(viewContext)
        {
        }

        /// <summary>
        /// Gets or sets the Gauge theme.
        /// </summary>
        /// <value>
        /// The Gauge theme.
        /// </value>
        public string Theme { get; set; }

        public List<LinearGaugePointer> Pointers { get; set; } = new List<LinearGaugePointer>();

        public LinearGaugePointer Pointer { get; set; } = new LinearGaugePointer();

        protected override void WriteHtml(TextWriter writer)
        {
            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            var pointers = Pointers.Select(i => i.Serialize());
            if (pointers.Any())
            {
                settings["pointer"] = pointers;
            }
            else
            {
                settings["pointer"] = Pointer.Serialize();
            }

            if (Theme.HasValue())
            {
                settings.Add("theme", Theme);
            }

            if (Transitions.HasValue && !Transitions.Value)
            {
                settings["transitions"] = Transitions;
            }
            
            writer.Write(Initializer.Initialize(Selector, "LinearGauge", settings));
        }
    }
}

