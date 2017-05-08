using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;

namespace Kendo.Mvc.UI
{
    /// <summary>
    /// Kendo UI Spreadsheet component
    /// </summary>
    public partial class Spreadsheet : WidgetBase
        
    {
        internal Dictionary<string, object> DplSettings { get; set; }

        public Spreadsheet(ViewContext viewContext) : base(viewContext)
        {
        }

        protected override void WriteHtml(TextWriter writer)
        {
            HtmlAttributes.Merge("data-role", "spreadsheet", true);

            var tag = Generator.GenerateTag("div", ViewContext, Id, Name, HtmlAttributes);

            tag.WriteTo(writer, HtmlEncoder);

            base.WriteHtml(writer);
        }

        public override void WriteInitializationScript(TextWriter writer)
        {
            var settings = SerializeSettings();

            if (DplSettings != null)
            {
                settings.Merge(DplSettings);
            }

            writer.Write(Initializer.Initialize(Selector, "Spreadsheet", settings));
        }
    }
}

