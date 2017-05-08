using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI RadialGauge component
    /// </summary>
    public partial class RadialGauge : WidgetBase 
    {
        public RadialGauge(ViewContext viewContext) : base(viewContext)
        {
        }

        public List<RadialGaugePointer> Pointers { get; set; } = new List<RadialGaugePointer>();

        public RadialGaugePointer Pointer { get; set; } = new RadialGaugePointer();


        /// <summary>
        /// Gets or sets the Gauge theme.
        /// </summary>
        /// <value>
        /// The Gauge theme.
        /// </value>
        public string Theme
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the render type.
        /// </summary>
        /// <value>The render type.</value>
        public RenderingMode? RenderAs
        {
            get;
            set;
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

            if (Theme.HasValue())
            {
                settings.Add("theme", Theme);
            }

            var pointers = Pointers.Select(i => i.Serialize());
            if (pointers.Any())
            {
                settings["pointer"] = pointers;
            }
            else
            {
                settings["pointer"] = Pointer.Serialize();
            }

            if (RenderAs.HasValue)
            {
                settings.Add("renderAs", RenderAs.ToString().ToLowerInvariant());
            }

            if (Theme.HasValue())
            {
                settings["theme"] = Theme;
            }

            if (Transitions.HasValue && !Transitions.Value)
            {
                settings["transitions"] = Transitions;
            }

            writer.Write(Initializer.Initialize(Selector, "RadialGauge", settings));
        }
    }
}

